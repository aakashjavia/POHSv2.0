namespace Job_Card_Creation
{
    partial class Main_Page
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
            this.title1 = new System.Windows.Forms.Label();
            this.toJobCardForm = new System.Windows.Forms.Button();
            this.toNewJobForm = new System.Windows.Forms.Button();
            this.ToInventory = new System.Windows.Forms.Button();
            this.toOrderStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(0, 0);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(988, 1031);
            this.title1.TabIndex = 1;
            this.title1.Text = "XYZ PACKAGING";
            this.title1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title1.Click += new System.EventHandler(this.title1_Click);
            // 
            // toJobCardForm
            // 
            this.toJobCardForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toJobCardForm.Location = new System.Drawing.Point(12, 258);
            this.toJobCardForm.Name = "toJobCardForm";
            this.toJobCardForm.Size = new System.Drawing.Size(392, 108);
            this.toJobCardForm.TabIndex = 2;
            this.toJobCardForm.Text = "Job Card Entry";
            this.toJobCardForm.UseVisualStyleBackColor = true;
            this.toJobCardForm.Click += new System.EventHandler(this.toJobCardForm_Click);
            // 
            // toNewJobForm
            // 
            this.toNewJobForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toNewJobForm.Location = new System.Drawing.Point(12, 476);
            this.toNewJobForm.Name = "toNewJobForm";
            this.toNewJobForm.Size = new System.Drawing.Size(392, 108);
            this.toNewJobForm.TabIndex = 4;
            this.toNewJobForm.Text = "New Job Entry";
            this.toNewJobForm.UseVisualStyleBackColor = true;
            this.toNewJobForm.Click += new System.EventHandler(this.toNewJobForm_Click);
            // 
            // ToInventory
            // 
            this.ToInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToInventory.Location = new System.Drawing.Point(584, 258);
            this.ToInventory.Name = "ToInventory";
            this.ToInventory.Size = new System.Drawing.Size(392, 108);
            this.ToInventory.TabIndex = 5;
            this.ToInventory.Text = "Inventory";
            this.ToInventory.UseVisualStyleBackColor = true;
            this.ToInventory.Click += new System.EventHandler(this.toInventory_Click);
            // 
            // toOrderStatus
            // 
            this.toOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toOrderStatus.Location = new System.Drawing.Point(584, 476);
            this.toOrderStatus.Name = "toOrderStatus";
            this.toOrderStatus.Size = new System.Drawing.Size(392, 108);
            this.toOrderStatus.TabIndex = 6;
            this.toOrderStatus.Text = "Order Status";
            this.toOrderStatus.UseVisualStyleBackColor = true;
            this.toOrderStatus.Click += new System.EventHandler(this.toOrderStatus_Click);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 1031);
            this.Controls.Add(this.toOrderStatus);
            this.Controls.Add(this.ToInventory);
            this.Controls.Add(this.toNewJobForm);
            this.Controls.Add(this.toJobCardForm);
            this.Controls.Add(this.title1);
            this.Location = new System.Drawing.Point(30, 30);
            this.Name = "Main_Page";
            this.Text = "Job Card Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Button toJobCardForm;
        private System.Windows.Forms.Button toNewJobForm;
        private System.Windows.Forms.Button ToInventory;
        private System.Windows.Forms.Button toOrderStatus;
    }
}