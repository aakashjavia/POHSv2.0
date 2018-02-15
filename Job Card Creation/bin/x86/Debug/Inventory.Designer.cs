namespace Job_Card_Creation
{
    partial class Inventory
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
            this.PaperTypeLabel = new System.Windows.Forms.Label();
            this.paper_type = new System.Windows.Forms.TextBox();
            this.lblPaperSize = new System.Windows.Forms.Label();
            this.lblPackets = new System.Windows.Forms.Label();
            this.lblSheets = new System.Windows.Forms.Label();
            this.paper_size = new System.Windows.Forms.TextBox();
            this.packets = new System.Windows.Forms.TextBox();
            this.sheets = new System.Windows.Forms.TextBox();
            this.lblSrNo = new System.Windows.Forms.Label();
            this.sr_no = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.HorizontalBar4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Info1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.threshold = new System.Windows.Forms.TextBox();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaperTypeLabel
            // 
            this.PaperTypeLabel.AutoSize = true;
            this.PaperTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.PaperTypeLabel.Location = new System.Drawing.Point(6, 306);
            this.PaperTypeLabel.Name = "PaperTypeLabel";
            this.PaperTypeLabel.Size = new System.Drawing.Size(183, 29);
            this.PaperTypeLabel.TabIndex = 77;
            this.PaperTypeLabel.Text = "Type Of Paper";
            // 
            // paper_type
            // 
            this.paper_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.paper_type.Location = new System.Drawing.Point(243, 306);
            this.paper_type.Name = "paper_type";
            this.paper_type.Size = new System.Drawing.Size(495, 34);
            this.paper_type.TabIndex = 79;
            this.paper_type.TextChanged += new System.EventHandler(this.paper_type_TextChanged);
            // 
            // lblPaperSize
            // 
            this.lblPaperSize.AutoSize = true;
            this.lblPaperSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPaperSize.Location = new System.Drawing.Point(6, 346);
            this.lblPaperSize.Name = "lblPaperSize";
            this.lblPaperSize.Size = new System.Drawing.Size(141, 29);
            this.lblPaperSize.TabIndex = 80;
            this.lblPaperSize.Text = "Paper Size";
            // 
            // lblPackets
            // 
            this.lblPackets.AutoSize = true;
            this.lblPackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPackets.Location = new System.Drawing.Point(6, 386);
            this.lblPackets.Name = "lblPackets";
            this.lblPackets.Size = new System.Drawing.Size(105, 29);
            this.lblPackets.TabIndex = 81;
            this.lblPackets.Text = "Packets";
            // 
            // lblSheets
            // 
            this.lblSheets.AutoSize = true;
            this.lblSheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSheets.Location = new System.Drawing.Point(6, 426);
            this.lblSheets.Name = "lblSheets";
            this.lblSheets.Size = new System.Drawing.Size(94, 29);
            this.lblSheets.TabIndex = 82;
            this.lblSheets.Text = "Sheets";
            // 
            // paper_size
            // 
            this.paper_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.paper_size.Location = new System.Drawing.Point(243, 346);
            this.paper_size.Name = "paper_size";
            this.paper_size.Size = new System.Drawing.Size(495, 34);
            this.paper_size.TabIndex = 83;
            // 
            // packets
            // 
            this.packets.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.packets.Location = new System.Drawing.Point(243, 386);
            this.packets.Name = "packets";
            this.packets.Size = new System.Drawing.Size(495, 34);
            this.packets.TabIndex = 84;
            // 
            // sheets
            // 
            this.sheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.sheets.Location = new System.Drawing.Point(243, 426);
            this.sheets.Name = "sheets";
            this.sheets.Size = new System.Drawing.Size(495, 34);
            this.sheets.TabIndex = 85;
            // 
            // lblSrNo
            // 
            this.lblSrNo.AutoSize = true;
            this.lblSrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSrNo.Location = new System.Drawing.Point(6, 266);
            this.lblSrNo.Name = "lblSrNo";
            this.lblSrNo.Size = new System.Drawing.Size(80, 29);
            this.lblSrNo.TabIndex = 86;
            this.lblSrNo.Text = "Sr No";
            // 
            // sr_no
            // 
            this.sr_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.sr_no.Location = new System.Drawing.Point(243, 266);
            this.sr_no.Name = "sr_no";
            this.sr_no.Size = new System.Drawing.Size(495, 34);
            this.sr_no.TabIndex = 87;
            this.sr_no.Click += new System.EventHandler(this.txtSrNo_OnClick);
            this.sr_no.TextChanged += new System.EventHandler(this.sr_no_TextChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.UpdateButton.Location = new System.Drawing.Point(173, 596);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(131, 43);
            this.UpdateButton.TabIndex = 88;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 166);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 700);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(101, 29);
            this.StatusLabel.TabIndex = 92;
            this.StatusLabel.Text = "Status:-";
            // 
            // HorizontalBar4
            // 
            this.HorizontalBar4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalBar4.Location = new System.Drawing.Point(11, 686);
            this.HorizontalBar4.Name = "HorizontalBar4";
            this.HorizontalBar4.Size = new System.Drawing.Size(991, 2);
            this.HorizontalBar4.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(991, 2);
            this.label2.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(252, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 32);
            this.label4.TabIndex = 95;
            this.label4.Text = "XYZ PACKAGING";
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info1.Location = new System.Drawing.Point(12, 224);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(292, 25);
            this.Info1.TabIndex = 96;
            this.Info1.Text = "Click on a row in the table to Edit";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.Location = new System.Drawing.Point(17, 596);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(131, 43);
            this.SubmitButton.TabIndex = 97;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // threshold
            // 
            this.threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.threshold.Location = new System.Drawing.Point(243, 466);
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(495, 34);
            this.threshold.TabIndex = 99;
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.AutoSize = true;
            this.ThresholdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.ThresholdLabel.Location = new System.Drawing.Point(6, 466);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(132, 29);
            this.ThresholdLabel.TabIndex = 98;
            this.ThresholdLabel.Text = "Threshold";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 738);
            this.Controls.Add(this.threshold);
            this.Controls.Add(this.ThresholdLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.HorizontalBar4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.sr_no);
            this.Controls.Add(this.lblSrNo);
            this.Controls.Add(this.sheets);
            this.Controls.Add(this.packets);
            this.Controls.Add(this.paper_size);
            this.Controls.Add(this.lblSheets);
            this.Controls.Add(this.lblPackets);
            this.Controls.Add(this.lblPaperSize);
            this.Controls.Add(this.paper_type);
            this.Controls.Add(this.PaperTypeLabel);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaperTypeLabel;
        private System.Windows.Forms.TextBox paper_type;
        private System.Windows.Forms.Label lblPaperSize;
        private System.Windows.Forms.Label lblPackets;
        private System.Windows.Forms.Label lblSheets;
        private System.Windows.Forms.TextBox paper_size;
        private System.Windows.Forms.TextBox packets;
        private System.Windows.Forms.TextBox sheets;
        private System.Windows.Forms.Label lblSrNo;
        private System.Windows.Forms.TextBox sr_no;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label HorizontalBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox threshold;
        private System.Windows.Forms.Label ThresholdLabel;
    }
}