namespace Job_Card_Creation.pages
{
    partial class GoogleDrivePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileLabel = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.UploadLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogInOutButton = new System.Windows.Forms.Button();
            this.LogInOutLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Location = new System.Drawing.Point(4, 4);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(59, 17);
            this.ConsoleLabel.TabIndex = 0;
            this.ConsoleLabel.Text = "Console";
            this.ConsoleLabel.Visible = false;
            // 
            // BrowseButton
            // 
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.BrowseButton.Location = new System.Drawing.Point(7, 38);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(183, 44);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.FileLabel.Location = new System.Drawing.Point(3, 85);
            this.FileLabel.MaximumSize = new System.Drawing.Size(700, 0);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(78, 25);
            this.FileLabel.TabIndex = 2;
            this.FileLabel.Text = "FilePath";
            // 
            // UploadButton
            // 
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.UploadButton.Location = new System.Drawing.Point(3, 195);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(183, 44);
            this.UploadButton.TabIndex = 3;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // UploadLabel
            // 
            this.UploadLabel.AutoSize = true;
            this.UploadLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.UploadLabel.Location = new System.Drawing.Point(-1, 242);
            this.UploadLabel.MaximumSize = new System.Drawing.Size(700, 0);
            this.UploadLabel.Name = "UploadLabel";
            this.UploadLabel.Size = new System.Drawing.Size(266, 25);
            this.UploadLabel.TabIndex = 4;
            this.UploadLabel.Text = "Upload the file selected above";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightYellow;
            this.pictureBox1.Image = global::Job_Card_Creation.Properties.Resources.Google_Drive_Lockup2;
            this.pictureBox1.Location = new System.Drawing.Point(4, 846);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LogInOutButton
            // 
            this.LogInOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInOutButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.LogInOutButton.Location = new System.Drawing.Point(3, 324);
            this.LogInOutButton.Name = "LogInOutButton";
            this.LogInOutButton.Size = new System.Drawing.Size(183, 44);
            this.LogInOutButton.TabIndex = 6;
            this.LogInOutButton.Text = "Log Out";
            this.LogInOutButton.UseVisualStyleBackColor = true;
            this.LogInOutButton.Click += new System.EventHandler(this.LogInOutButton_Click);
            // 
            // LogInOutLabel1
            // 
            this.LogInOutLabel1.AutoSize = true;
            this.LogInOutLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.LogInOutLabel1.Location = new System.Drawing.Point(2, 371);
            this.LogInOutLabel1.MaximumSize = new System.Drawing.Size(700, 0);
            this.LogInOutLabel1.Name = "LogInOutLabel1";
            this.LogInOutLabel1.Size = new System.Drawing.Size(526, 25);
            this.LogInOutLabel1.TabIndex = 7;
            this.LogInOutLabel1.Text = "This Will Log you out without asking for further confirmation.";
            // 
            // GoogleDrivePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.Controls.Add(this.LogInOutLabel1);
            this.Controls.Add(this.LogInOutButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UploadLabel);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ConsoleLabel);
            this.Name = "GoogleDrivePage";
            this.Size = new System.Drawing.Size(773, 932);
            this.Load += new System.EventHandler(this.GoogleDrivePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsoleLabel;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Label UploadLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogInOutButton;
        private System.Windows.Forms.Label LogInOutLabel1;
    }
}
