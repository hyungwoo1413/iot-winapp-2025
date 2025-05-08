namespace Client
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtID = new TextBox();
            label1 = new Label();
            TxtPW = new TextBox();
            label2 = new Label();
            BtnLogin = new Button();
            BtnJoin = new Button();
            SuspendLayout();
            // 
            // TxtID
            // 
            TxtID.Font = new Font("나눔고딕", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            TxtID.Location = new Point(112, 50);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(165, 27);
            TxtID.TabIndex = 1;
            TxtID.KeyDown += TxtID_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 34);
            label1.Name = "label1";
            label1.Size = new Size(40, 14);
            label1.TabIndex = 1;
            label1.Text = "아이디";
            // 
            // TxtPW
            // 
            TxtPW.Font = new Font("나눔고딕", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            TxtPW.Location = new Point(112, 108);
            TxtPW.Name = "TxtPW";
            TxtPW.Size = new Size(165, 27);
            TxtPW.TabIndex = 2;
            TxtPW.KeyDown += TxtPW_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 91);
            label2.Name = "label2";
            label2.Size = new Size(51, 14);
            label2.TabIndex = 1;
            label2.Text = "비밀번호";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(198, 158);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(79, 32);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "로그인";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnJoin
            // 
            BtnJoin.Location = new Point(112, 158);
            BtnJoin.Name = "BtnJoin";
            BtnJoin.Size = new Size(79, 32);
            BtnJoin.TabIndex = 3;
            BtnJoin.Text = "회원가입";
            BtnJoin.UseVisualStyleBackColor = true;
            BtnJoin.Click += BtnJoin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 229);
            Controls.Add(BtnJoin);
            Controls.Add(BtnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPW);
            Controls.Add(TxtID);
            Font = new Font("나눔고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "로그인";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtID;
        private Label label1;
        private TextBox TxtPW;
        private Label label2;
        private Button BtnLogin;
        private Button BtnJoin;
    }
}