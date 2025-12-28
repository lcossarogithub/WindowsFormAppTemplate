namespace WindowsFormAppTemplate.Forms
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            btnClose = new Button();
            lblTitle = new Label();
            lblVersion = new Label();
            txtVersion = new Label();
            picIcon = new PictureBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(292, 223);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(81, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "TITLE";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(81, 45);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(51, 15);
            lblVersion.TabIndex = 3;
            lblVersion.Text = "Version: ";
            // 
            // txtVersion
            // 
            txtVersion.AutoSize = true;
            txtVersion.Location = new Point(138, 45);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(40, 15);
            txtVersion.TabIndex = 4;
            txtVersion.Text = "x.x.x.x";
            // 
            // picIcon
            // 
            picIcon.Image = (Image)resources.GetObject("picIcon.Image");
            picIcon.Location = new Point(12, 12);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(48, 48);
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.TabIndex = 5;
            picIcon.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(81, 79);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(286, 138);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 258);
            Controls.Add(richTextBox1);
            Controls.Add(picIcon);
            Controls.Add(txtVersion);
            Controls.Add(lblVersion);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblVersion;
        private Label txtVersion;
        private PictureBox picIcon;
        private RichTextBox richTextBox1;
    }
}