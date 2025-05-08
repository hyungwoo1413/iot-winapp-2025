using System.Net.Sockets;
using System.Text;

namespace Client
{
    public partial class FrmMain : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string userId;
        private string userName;

        private Thread receiveThread;

        public FrmMain(TcpClient c, NetworkStream s, string id, string name)
        {
            InitializeComponent();
            client = c;
            stream = s;
            userId = id;
            userName = name;
        }

        private void BtnChatInput_Click(object sender, EventArgs e)
        {
            string message = TxtChatInput.Text.Trim();

            if (string.IsNullOrEmpty(message))
            {
                return;
            }

            try
            {
                string sendMsg = $"CHAT {userId} {message}";
                byte[] buffer = Encoding.UTF8.GetBytes(sendMsg);
                stream.Write(buffer, 0, buffer.Length);

                TxtChatInput.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("메시지 전송 실패");
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            receiveThread = new Thread(ReceiveMessages);
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int len = stream.Read(buffer, 0, buffer.Length);
                    if (len == 0) break;

                    string msg = Encoding.UTF8.GetString(buffer, 0, len);

                    if (msg.StartsWith("CHAT "))
                    {
                        string[] parts = msg.Substring(5).Split(new[] { ' ' }, 2);  // [0]: id, [1]: msg
                        if (parts.Length == 2)
                        {
                            string name = parts[0];
                            string message = parts[1];

                            LsbChatOutput.Items.Add($"[{name}] {message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("서버와의 연결이 끊어졌습니다: " + ex.Message);
                    this.Close();
                }));
            }
        }

        private void TxtChatInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnChatInput.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LsbUser.Items.Add($"{userName}");
        }
    }
}