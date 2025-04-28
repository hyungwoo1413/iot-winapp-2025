#include <iostream>
#include <asio.hpp>
#include <vector>
#include <map>

using asio::ip::tcp;
std::atomic<int> num_counter(1);
std::vector<std::shared_ptr<tcp::socket>> sockets;
std::mutex sockets_mutex;
std::vector<std::string> ids;

/* 로그인 */
void login(std::istringstream& iss, std::shared_ptr<tcp::socket> socket, int num) {
	std::string id, pw;
	iss >> id >> pw;

	std::string response;

	if (id == "abc" && pw == "123") {
		std::cout << "[" << num << "] " << "로그인 성공" << "(" << id << ", " << pw << ")" << std::endl;
		response = "LOGIN TRUE";
	}
	else {
		std::cout << "[" << num << "] " << "로그인 실패" << "(" << id << ", " << pw << ")" << std::endl;
		response = "LOGIN FALSE";
	}
	asio::write(*socket, asio::buffer(response));
}

/* 채팅 */
void chat(std::istringstream& iss) {
	std::string id, chat_msg;
	iss >> id;
	std::getline(iss >> std::ws, chat_msg);
	std::cout << "[" << id << "] " << chat_msg << std::endl;

	std::string response = "CHAT " + id + " " + chat_msg;
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

			if (command == "LOGIN") {
				login(iss, socket, num);
			}
			else if (command == "CHAT") {
				chat(iss);
			}
			else if (command == "") {

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
			std::cout << "[" << num << "] " << "연결 완료" << std::endl;

			std::thread t(handler, socket, num);
			t.detach();
		}
	}
	catch (std::exception& e) {
		std::cerr << "예외: " << e.what() << std::endl;
	}

	return 0;
}

