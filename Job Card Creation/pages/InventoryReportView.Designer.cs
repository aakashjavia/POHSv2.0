namespace Job_Card_Creation.pages
{
    partial class InventoryReportView
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.FieldSelectButton = new System.Windows.Forms.Button();
            this.FieldListBox1 = new System.Windows.Forms.CheckedListBox();
            this.StatusLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(857, 876);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // FieldSelectButton
            // 
            this.FieldSelectButton.AutoSize = true;
            this.FieldSelectButton.BackColor = System.Drawing.Color.White;
            this.FieldSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FieldSelectButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldSelectButton.Location = new System.Drawing.Point(12, 882);
            this.FieldSelectButton.Name = "FieldSelectButton";
            this.FieldSelectButton.Size = new System.Drawing.Size(183, 44);
            this.FieldSelectButton.TabIndex = 101;
            this.FieldSelectButton.Text = "Choose Fields";
            this.FieldSelectButton.UseVisualStyleBackColor = false;
            this.FieldSelectButton.Click += new System.EventHandler(this.FieldSelectButton_Click);
            // 
            // FieldListBox1
            // 
            this.FieldListBox1.CheckOnClick = true;
            this.FieldListBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.FieldListBox1.FormattingEnabled = true;
            this.FieldListBox1.Items.AddRange(new object[] {
            "Sr No",
            "Paper Size",
            "Packets"});
            this.FieldListBox1.Location = new System.Drawing.Point(252, 882);
            this.FieldListBox1.MultiColumn = true;
            this.FieldListBox1.Name = "FieldListBox1";
            this.FieldListBox1.Size = new System.Drawing.Size(388, 108);
            this.FieldListBox1.TabIndex = 103;
            this.FieldListBox1.SelectedIndexChanged += new System.EventHandler(this.FieldListBox1_SelectedIndexChanged);
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.AutoSize = true;
            this.StatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel1.Location = new System.Drawing.Point(6, 1001);
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(101, 32);
            this.StatusLabel1.TabIndex = 258;
            this.StatusLabel1.Text = "Status: -";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(9, 999);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2000, 2);
            this.label1.TabIndex = 257;
            // 
            // InventoryReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 1033);
            this.Controls.Add(this.StatusLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FieldListBox1);
            this.Controls.Add(this.FieldSelectButton);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "InventoryReportView";
            this.Text = "InventoryReportView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryReportView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button FieldSelectButton;
        private System.Windows.Forms.CheckedListBox FieldListBox1;
        private System.Windows.Forms.Label StatusLabel1;
        private System.Windows.Forms.Label label1;
    }
}