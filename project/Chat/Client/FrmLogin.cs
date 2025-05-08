using System.Net.Sockets;
using System.Text;


namespace Client
{
    public partial class FrmLogin : Form
    {
        public TcpClient Client { get; private set; }
        public NetworkStream Stream { get; private set; }
        public string UserId { get; private set; }
        public string UserName { get; private set; }

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
                MessageBox.Show("서버 연결 성공");
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버 연결 실패");
                this.Close();
            }
        }
        private void BtnJoin_Click(object sender, EventArgs e)
        {
            FrmJoin joinForm = new FrmJoin(this.Client, this.Stream);  // 연결 정보 전달
            joinForm.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string id = TxtID.Text.Trim();
            string pw = TxtPW.Text.Trim();

            string loginMsg = $"LOGIN {id} {pw}";
            byte[] buffer = Encoding.UTF8.GetBytes(loginMsg);
            this.Stream.Write(buffer, 0, buffer.Length);

            byte[] recvBuffer = new byte[1024];
            int len = this.Stream.Read(recvBuffer, 0, recvBuffer.Length);
            string response = Encoding.UTF8.GetString(recvBuffer, 0, len);

            if (response.Contains("LOGIN TRUE"))
            {
                string[] tokens = response.Split(' ');
                if (tokens.Length >= 3)
                {
                    this.UserId = id;
                    string username = tokens[2];
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (response.Contains("LOGIN FALSE"))
            {
                MessageBox.Show("로그인 실패!");
            }
        }
        private void TxtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void TxtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

    }
}
