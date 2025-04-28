using System.Net.Sockets;
using System.Text;


namespace Client
{
    public partial class FrmLogin : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 8080);  // 서버 연결
                stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버 연결 실패: " + ex.Message);
                this.Close();
            }
        }

        private void Btn_join_Click(object sender, EventArgs e)
        {
            string id = TxtId.Text.Trim();
            string pw = TxtPassword.Text.Trim();

            string loginMsg = $"LOGIN {id} {pw}";
            byte[] buffer = Encoding.UTF8.GetBytes(loginMsg);
            stream.Write(buffer, 0, buffer.Length);

            byte[] recvBuffer = new byte[1024];
            int len = stream.Read(recvBuffer, 0, recvBuffer.Length);
            string response = Encoding.UTF8.GetString(recvBuffer, 0, len);

            if (response.Contains("LOGIN TRUE"))
            {
                FrmMain chatForm = new FrmMain(client, stream, id);
                chatForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("로그인 실패!");
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (FrmMain chatForm = new FrmMain(client, stream, TxtId.Text))
            {
                chatForm.ShowDialog();
            }
            this.Close();
        }

    }
}
