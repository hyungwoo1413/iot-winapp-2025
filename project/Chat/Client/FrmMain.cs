using System.Net.Sockets;

namespace Client
{
    public partial class FrmMain : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string userId;

        public FrmMain(TcpClient c, NetworkStream s, string id)
        {
            InitializeComponent();
            client = c;
            stream = s;
            userId = id;
        }
    }
}