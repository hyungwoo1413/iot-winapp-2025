using System.Net.Sockets;
using System.Text;


namespace Client
{
    public partial class FrmLogin : Form
    {
        public TcpClient Client { get; private set; }
        public NetworkStream Stream { get; private set; }
        public string UserId { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.Client = new TcpClient("127.0.0.1", 8080);  // 서버 연결
                this.Stream = Client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버 연결 실패: " + ex.Message);
                this.Close();
            }
        }
        private void BtnJoin_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string id = TxtId.Text.Trim();
            string pw = TxtPassword.Text.Trim();

            string loginMsg = $"LOGIN {id} {pw}";
            byte[] buffer = Encoding.UTF8.GetBytes(loginMsg);
            this.Stream.Write(buffer, 0, buffer.Length);

            byte[] recvBuffer = new byte[1024];
            int len = this.Stream.Read(recvBuffer, 0, recvBuffer.Length);
            string response = Encoding.UTF8.GetString(recvBuffer, 0, len);

            if (response.Contains("LOGIN TRUE"))
            {
                this.UserId = id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (response.Contains("LOGIN FALSE"))
            {
                MessageBox.Show("로그인 실패!");
            }
        }
    }
}
