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
            TxtChatOutput = new TextBox();
            TxtChatInput = new TextBox();
            imageList1 = new ImageList(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // TxtChatOutput
            // 
            TxtChatOutput.Location = new Point(12, 12);
            TxtChatOutput.Multiline = true;
            TxtChatOutput.Name = "TxtChatOutput";
            TxtChatOutput.Size = new Size(440, 486);
            TxtChatOutput.TabIndex = 0;
            // 
            // TxtChatInput
            // 
            TxtChatInput.Location = new Point(12, 522);
            TxtChatInput.Name = "TxtChatInput";
            TxtChatInput.Size = new Size(411, 23);
            TxtChatInput.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "next.png");
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(429, 522);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 561);
            Controls.Add(button1);
            Controls.Add(TxtChatInput);
            Controls.Add(TxtChatOutput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtChatOutput;
        private TextBox TxtChatInput;
        private ImageList imageList1;
        private Button button1;
    }
}
