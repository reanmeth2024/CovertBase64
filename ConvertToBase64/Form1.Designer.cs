namespace ConvertToBase64
{
    partial class Form1
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
            btnChange64 = new Button();
            lbbase64 = new Label();
            txbBase64 = new TextBox();
            ChangePNG = new Button();
            label1 = new Label();
            txtInBase64 = new RichTextBox();
            SuspendLayout();
            // 
            // btnChange64
            // 
            btnChange64.Location = new Point(12, 12);
            btnChange64.Name = "btnChange64";
            btnChange64.Size = new Size(75, 23);
            btnChange64.TabIndex = 0;
            btnChange64.Text = "To Base64";
            btnChange64.UseVisualStyleBackColor = true;
            btnChange64.Click += btnChange64_Click;
            // 
            // lbbase64
            // 
            lbbase64.AutoSize = true;
            lbbase64.Location = new Point(93, 16);
            lbbase64.Name = "lbbase64";
            lbbase64.Size = new Size(90, 15);
            lbbase64.TabIndex = 4;
            lbbase64.Text = "Xuất mã Base64";
            // 
            // txbBase64
            // 
            txbBase64.Location = new Point(199, 13);
            txbBase64.Multiline = true;
            txbBase64.Name = "txbBase64";
            txbBase64.Size = new Size(223, 23);
            txbBase64.TabIndex = 5;
            // 
            // ChangePNG
            // 
            ChangePNG.Location = new Point(12, 53);
            ChangePNG.Name = "ChangePNG";
            ChangePNG.Size = new Size(75, 23);
            ChangePNG.TabIndex = 6;
            ChangePNG.Text = "To PNG";
            ChangePNG.UseVisualStyleBackColor = true;
            ChangePNG.Click += ChangePNG_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 57);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 8;
            label1.Text = "Nhập Mã Base64";
            // 
            // txtInBase64
            // 
            txtInBase64.Location = new Point(199, 53);
            txtInBase64.Name = "txtInBase64";
            txtInBase64.Size = new Size(570, 272);
            txtInBase64.TabIndex = 9;
            txtInBase64.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInBase64);
            Controls.Add(label1);
            Controls.Add(ChangePNG);
            Controls.Add(txbBase64);
            Controls.Add(lbbase64);
            Controls.Add(btnChange64);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChange64;
        private Label lbbase64;
        private TextBox txbBase64;
        private Button ChangePNG;
        private Label label1;
        private RichTextBox txtInBase64;
    }
}
