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
            TxtId = new TextBox();
            label1 = new Label();
            TxtPassword = new TextBox();
            label2 = new Label();
            Btn_login = new Button();
            Btn_join = new Button();
            SuspendLayout();
            // 
            // TxtId
            // 
            TxtId.Font = new Font("나눔고딕", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            TxtId.Location = new Point(112, 50);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(165, 27);
            TxtId.TabIndex = 0;
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
            // TxtPassword
            // 
            TxtPassword.Font = new Font("나눔고딕", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            TxtPassword.Location = new Point(112, 108);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(165, 27);
            TxtPassword.TabIndex = 0;
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
            // Btn_login
            // 
            Btn_login.Location = new Point(198, 158);
            Btn_login.Name = "Btn_login";
            Btn_login.Size = new Size(79, 32);
            Btn_login.TabIndex = 2;
            Btn_login.Text = "로그인";
            Btn_login.UseVisualStyleBackColor = true;
            Btn_login.Click += Btn_login_Click;
            // 
            // Btn_join
            // 
            Btn_join.Location = new Point(112, 158);
            Btn_join.Name = "Btn_join";
            Btn_join.Size = new Size(79, 32);
            Btn_join.TabIndex = 2;
            Btn_join.Text = "회원가입";
            Btn_join.UseVisualStyleBackColor = true;
            Btn_join.Click += Btn_join_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 229);
            Controls.Add(Btn_join);
            Controls.Add(Btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPassword);
            Controls.Add(TxtId);
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

        private TextBox TxtId;
        private Label label1;
        private TextBox TxtPassword;
        private Label label2;
        private Button Btn_login;
        private Button Btn_join;
    }
}