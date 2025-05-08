namespace Client
{
    partial class FrmJoin
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
            label2 = new Label();
            label1 = new Label();
            Txt_PW = new TextBox();
            Txt_ID = new TextBox();
            Txt_PWCheck = new TextBox();
            label3 = new Label();
            Btn_Join = new Button();
            Txt_Name = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 95);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "비밀번호";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "아이디";
            // 
            // Txt_PW
            // 
            Txt_PW.Font = new Font("나눔고딕", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Txt_PW.Location = new Point(83, 112);
            Txt_PW.Name = "Txt_PW";
            Txt_PW.Size = new Size(165, 27);
            Txt_PW.TabIndex = 6;
            // 
            // Txt_ID
            // 
            Txt_ID.Font = new Font("나눔고딕", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Txt_ID.Location = new Point(83, 54);
            Txt_ID.Name = "Txt_ID";
            Txt_ID.Size = new Size(165, 27);
            Txt_ID.TabIndex = 5;
            // 
            // Txt_PWCheck
            // 
            Txt_PWCheck.Font = new Font("나눔고딕", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Txt_PWCheck.Location = new Point(83, 174);
            Txt_PWCheck.Name = "Txt_PWCheck";
            Txt_PWCheck.Size = new Size(165, 27);
            Txt_PWCheck.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 157);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 3;
            label3.Text = "비밀번호 확인";
            // 
            // Btn_Join
            // 
            Btn_Join.Location = new Point(121, 292);
            Btn_Join.Name = "Btn_Join";
            Btn_Join.Size = new Size(79, 32);
            Btn_Join.TabIndex = 7;
            Btn_Join.Text = "회원가입";
            Btn_Join.UseVisualStyleBackColor = true;
            Btn_Join.Click += Btn_Join_Click;
            // 
            // Txt_Name
            // 
            Txt_Name.Font = new Font("나눔고딕", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Txt_Name.Location = new Point(83, 233);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(165, 27);
            Txt_Name.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 216);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "이름";
            // 
            // FrmJoin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 361);
            Controls.Add(Btn_Join);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txt_Name);
            Controls.Add(Txt_PWCheck);
            Controls.Add(Txt_PW);
            Controls.Add(Txt_ID);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmJoin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmJoin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox Txt_PW;
        private TextBox Txt_ID;
        private TextBox Txt_PWCheck;
        private Label label3;
        private Button Btn_Join;
        private TextBox Txt_Name;
        private Label label4;
    }
}