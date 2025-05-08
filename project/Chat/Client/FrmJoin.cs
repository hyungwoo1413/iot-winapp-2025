using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmJoin : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public FrmJoin(TcpClient client, NetworkStream stream)
        {
            InitializeComponent();
            this.client = client;
            this.stream = stream;
        }

        private void Btn_Join_Click(object sender, EventArgs e)
        {
            string id = Txt_ID.Text.Trim();
            string pw = Txt_PW.Text.Trim();
            string pwcheck = Txt_PWCheck.Text.Trim();
            string name = Txt_Name.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pw) || string.IsNullOrEmpty(pwcheck) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("입력을 확인하세요.");
                return;
            }

            if (pw != pwcheck)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return;
            }

            try
            {
                string joinMsg = $"JOIN {id} {pw} {name}";
                byte[] buffer = Encoding.UTF8.GetBytes(joinMsg);
                this.stream.Write(buffer, 0, buffer.Length);

                byte[] recvBuffer = new byte[1024];
                int len = this.stream.Read(recvBuffer, 0, recvBuffer.Length);
                string response = Encoding.UTF8.GetString(recvBuffer, 0, len);

                if (response.Contains("JOIN SUCCESS"))
                {
                    MessageBox.Show("회원가입 성공!");
                    this.Close();
                }
                else if (response.Contains("JOIN FAIL"))
                {
                    MessageBox.Show("이미 존재하는 ID입니다.");
                }
                else
                {
                    MessageBox.Show("서버로부터 알 수 없는 응답: " + response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
        }
    }
}
