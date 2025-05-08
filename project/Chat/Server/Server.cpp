#include <iostream>
#include <asio.hpp>
#include <vector>
#include <map>

using asio::ip::tcp;
std::atomic<int> num_counter(1);
std::vector<std::shared_ptr<tcp::socket>> sockets;
std::mutex sockets_mutex;
std::vector<std::string> ids;

std::mutex user_mutex;

struct UserInfo {
	std::string pw;
	std::string name;
};
std::map<std::string, UserInfo> user_db; // 유저 정보

/* 회원가입 */
void join(std::istringstream& iss, std::shared_ptr<tcp::socket> socket, int num) {
	std::string id, pw, name;
	iss >> id >> pw >> name;

	std::string response;

	{
		std::lock_guard<std::mutex> lock(user_mutex);
		if (user_db.find(id) != user_db.end()) {
			response = "JOIN FAIL";  // 이미 존재하는 ID
			std::cout << "[" << num << "] " << "회원가입 실패 (" << id << ")" << std::endl;
		}
		else {
			user_db[id] = { pw, name };
			response = "JOIN SUCCESS";
			std::cout << "[" << num << "] " << "회원가입 성공 (" << id << ", " << pw << ")" << std::endl;
		}
	}

	asio::write(*socket, asio::buffer(response));
}

/* 로그인 */
void login(std::istringstream& iss, std::shared_ptr<tcp::socket> socket, int num) {
	std::string id, pw;
	iss >> id >> pw;

	std::string response;

	{
		std::lock_guard<std::mutex> lock(user_mutex);
		auto it = user_db.find(id);

		if (it != user_db.end() && it->second.pw == pw) {
			// 로그인 성공
			std::cout << "[" << num << "] 로그인 성공 (" << id << ", " << pw << ")" << std::endl;
			response = "LOGIN TRUE " + it->second.name;
		}
		else {
			// 로그인 실패
			std::cout << "[" << num << "] 로그인 실패 (" << id << ", " << pw << ")" << std::endl;
			response = "LOGIN FALSE";
		}
	}

	asio::write(*socket, asio::buffer(response));
}

/* 채팅 */
void chat(std::istringstream& iss) {
	std::string id, chat_msg;
	iss >> id;
	std::getline(iss >> std::ws, chat_msg);

	std::cout << "[" << id << "] " << chat_msg << std::endl;

	std::string name;
	{
		std::lock_guard<std::mutex> lock(user_mutex);
		auto it = user_db.find(id);
		if (it != user_db.end()) {
			name = it->second.name;
		}
		else {
			name = id;  // fallback
		}
	}

	std::string response = "CHAT " + name + " " + chat_msg;
	std::lock_guard<std::mutex> lock(sockets_mutex);
	for (auto& socket : sockets) {
		asio::error_code ec;
		asio::write(*socket, asio::buffer(response), ec);
	}

}

/* 핸들러 */
void handler(std::shared_ptr<tcp::socket> socket, int num) {
	{
		std::lock_guard<std::mutex> lock(sockets_mutex);
		sockets.push_back(socket);
	}

	try {
		while (true) {
			std::string msg(1024, '\0');
			std::error_code ec;
			size_t len = socket->read_some(asio::buffer(msg), ec);  // read

			if (ec || ec == asio::error::eof) {
				std::cout << "[" << num << "] 연결 종료" << std::endl;
				break;
			}

			msg.resize(len);
			std::istringstream iss(msg);
			std::string command;
			iss >> command;

			if (command == "JOIN") {
				join(iss, socket, num);
			}
			else if (command == "LOGIN") {
				login(iss, socket, num);
			}
			else if (command == "CHAT") {
				chat(iss);
			}
			else {
				std::cout << "[" << num << "] 알 수 없는 명령: " << command << std::endl;
			}
		}
	}
	catch (std::exception& e) {
		std::cerr << "[" << num << "] 예외: " << e.what() << std::endl;
	}

	{
		std::lock_guard<std::mutex> lock(sockets_mutex);
		sockets.erase(std::remove(sockets.begin(), sockets.end(), socket), sockets.end());
	}
}

/* 메인 */
int main() {
	try {
		asio::io_context io_context;
		tcp::acceptor acceptor(io_context, tcp::endpoint(tcp::v4(), 8080));
		std::cout << "연결 대기중" << std::endl;

		while (true) {
			auto socket = std::make_shared<tcp::socket>(io_context);
			acceptor.accept(*socket);

			int num = num_counter++;
			std::cout << "[" << num << "] " << "연결 성공" << std::endl;

			std::thread t(handler, socket, num);
			t.detach();
		}
	}
	catch (std::exception& e) {
		std::cerr << "예외: " << e.what() << std::endl;
	}

	return 0;
}

