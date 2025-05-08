namespace Client
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            TxtChatInput = new TextBox();
            imageList1 = new ImageList(components);
            BtnChatInput = new Button();
            LsbChatOutput = new ListBox();
            SuspendLayout();
            // 
            // TxtChatInput
            // 
            TxtChatInput.Location = new Point(12, 522);
            TxtChatInput.MaxLength = 30;
            TxtChatInput.Name = "TxtChatInput";
            TxtChatInput.Size = new Size(411, 23);
            TxtChatInput.TabIndex = 1;
            TxtChatInput.KeyDown += TxtChatInput_KeyDown;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "next.png");
            // 
            // BtnChatInput
            // 
            BtnChatInput.BackColor = Color.Transparent;
            BtnChatInput.FlatAppearance.BorderSize = 0;
            BtnChatInput.FlatStyle = FlatStyle.Flat;
            BtnChatInput.Image = (Image)resources.GetObject("BtnChatInput.Image");
            BtnChatInput.Location = new Point(429, 522);
            BtnChatInput.Name = "BtnChatInput";
            BtnChatInput.Size = new Size(23, 23);
            BtnChatInput.TabIndex = 2;
            BtnChatInput.UseVisualStyleBackColor = false;
            BtnChatInput.Click += BtnChatInput_Click;
            // 
            // LsbChatOutput
            // 
            LsbChatOutput.FormattingEnabled = true;
            LsbChatOutput.ItemHeight = 15;
            LsbChatOutput.Location = new Point(12, 12);
            LsbChatOutput.Name = "LsbChatOutput";
            LsbChatOutput.Size = new Size(440, 499);
            LsbChatOutput.TabIndex = 3;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 561);
            Controls.Add(LsbChatOutput);
            Controls.Add(BtnChatInput);
            Controls.Add(TxtChatInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtChatInput;
        private ImageList imageList1;
        private Button BtnChatInput;
        private ListBox LsbChatOutput;
    }
}
