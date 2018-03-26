namespace Job_Card_Creation
{
    partial class NewJob
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paper_type = new System.Windows.Forms.TextBox();
            this.sr_no = new System.Windows.Forms.TextBox();
            this.JobSheetNo = new System.Windows.Forms.Label();
            this.StatusLabel1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.varnish = new System.Windows.Forms.TextBox();
            this.color_shades = new System.Windows.Forms.TextBox();
            this.VarnishLabel = new System.Windows.Forms.Label();
            this.Shade_Nos_Label = new System.Windows.Forms.Label();
            this.num_of_colors = new System.Windows.Forms.TextBox();
            this.ColorsLabel = new System.Windows.Forms.Label();
            this.cutting_size = new System.Windows.Forms.TextBox();
            this.SheetCuttingLabel = new System.Windows.Forms.Label();
            this.PaperDetails = new System.Windows.Forms.Label();
            this.sheet_size = new System.Windows.Forms.TextBox();
            this.SheetSizeLabel = new System.Windows.Forms.Label();
            this.PaperTypeLabel = new System.Windows.Forms.Label();
            this.HorizontalBar3 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.TextBox();
            this.item_code = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.party_name = new System.Windows.Forms.TextBox();
            this.BoxSizeLabel = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.PartyLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(4, 889);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 2);
            this.label1.TabIndex = 103;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 168);
            this.dataGridView1.TabIndex = 260;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // paper_type
            // 
            this.paper_type.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper_type.Location = new System.Drawing.Point(222, 440);
            this.paper_type.Name = "paper_type";
            this.paper_type.Size = new System.Drawing.Size(517, 38);
            this.paper_type.TabIndex = 259;
            // 
            // sr_no
            // 
            this.sr_no.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.sr_no.Location = new System.Drawing.Point(222, 177);
            this.sr_no.Name = "sr_no";
            this.sr_no.Size = new System.Drawing.Size(208, 38);
            this.sr_no.TabIndex = 258;
            // 
            // JobSheetNo
            // 
            this.JobSheetNo.AutoSize = true;
            this.JobSheetNo.BackColor = System.Drawing.Color.Transparent;
            this.JobSheetNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobSheetNo.Location = new System.Drawing.Point(3, 180);
            this.JobSheetNo.Name = "JobSheetNo";
            this.JobSheetNo.Size = new System.Drawing.Size(164, 32);
            this.JobSheetNo.TabIndex = 257;
            this.JobSheetNo.Text = "Job Sheet No.";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.AutoSize = true;
            this.StatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel1.Location = new System.Drawing.Point(2, 891);
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(101, 32);
            this.StatusLabel1.TabIndex = 256;
            this.StatusLabel1.Text = "Status: -";
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.SubmitButton.Location = new System.Drawing.Point(200, 706);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(183, 44);
            this.SubmitButton.TabIndex = 255;
            this.SubmitButton.Text = "Submit Only";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // varnish
            // 
            this.varnish.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.varnish.Location = new System.Drawing.Point(222, 660);
            this.varnish.Name = "varnish";
            this.varnish.Size = new System.Drawing.Size(517, 38);
            this.varnish.TabIndex = 254;
            // 
            // color_shades
            // 
            this.color_shades.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.color_shades.Location = new System.Drawing.Point(222, 616);
            this.color_shades.Name = "color_shades";
            this.color_shades.Size = new System.Drawing.Size(517, 38);
            this.color_shades.TabIndex = 253;
            // 
            // VarnishLabel
            // 
            this.VarnishLabel.AutoSize = true;
            this.VarnishLabel.BackColor = System.Drawing.Color.Transparent;
            this.VarnishLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarnishLabel.Location = new System.Drawing.Point(5, 663);
            this.VarnishLabel.Name = "VarnishLabel";
            this.VarnishLabel.Size = new System.Drawing.Size(171, 32);
            this.VarnishLabel.TabIndex = 252;
            this.VarnishLabel.Text = "Varnish Details";
            // 
            // Shade_Nos_Label
            // 
            this.Shade_Nos_Label.AutoSize = true;
            this.Shade_Nos_Label.BackColor = System.Drawing.Color.Transparent;
            this.Shade_Nos_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shade_Nos_Label.Location = new System.Drawing.Point(5, 619);
            this.Shade_Nos_Label.Name = "Shade_Nos_Label";
            this.Shade_Nos_Label.Size = new System.Drawing.Size(155, 32);
            this.Shade_Nos_Label.TabIndex = 251;
            this.Shade_Nos_Label.Text = "Color Shades";
            // 
            // num_of_colors
            // 
            this.num_of_colors.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.num_of_colors.Location = new System.Drawing.Point(222, 572);
            this.num_of_colors.Name = "num_of_colors";
            this.num_of_colors.Size = new System.Drawing.Size(517, 38);
            this.num_of_colors.TabIndex = 250;
            // 
            // ColorsLabel
            // 
            this.ColorsLabel.AutoSize = true;
            this.ColorsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ColorsLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.ColorsLabel.Location = new System.Drawing.Point(5, 575);
            this.ColorsLabel.Name = "ColorsLabel";
            this.ColorsLabel.Size = new System.Drawing.Size(82, 32);
            this.ColorsLabel.TabIndex = 249;
            this.ColorsLabel.Text = "Colors";
            // 
            // cutting_size
            // 
            this.cutting_size.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.cutting_size.Location = new System.Drawing.Point(222, 528);
            this.cutting_size.Name = "cutting_size";
            this.cutting_size.Size = new System.Drawing.Size(517, 38);
            this.cutting_size.TabIndex = 248;
            // 
            // SheetCuttingLabel
            // 
            this.SheetCuttingLabel.AutoSize = true;
            this.SheetCuttingLabel.BackColor = System.Drawing.Color.Transparent;
            this.SheetCuttingLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetCuttingLabel.Location = new System.Drawing.Point(5, 531);
            this.SheetCuttingLabel.Name = "SheetCuttingLabel";
            this.SheetCuttingLabel.Size = new System.Drawing.Size(212, 32);
            this.SheetCuttingLabel.TabIndex = 247;
            this.SheetCuttingLabel.Text = "Sheet Cutting Size";
            // 
            // PaperDetails
            // 
            this.PaperDetails.AutoSize = true;
            this.PaperDetails.BackColor = System.Drawing.Color.Transparent;
            this.PaperDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperDetails.Location = new System.Drawing.Point(2, 407);
            this.PaperDetails.Name = "PaperDetails";
            this.PaperDetails.Size = new System.Drawing.Size(165, 32);
            this.PaperDetails.TabIndex = 246;
            this.PaperDetails.Text = "Paper Details";
            // 
            // sheet_size
            // 
            this.sheet_size.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.sheet_size.Location = new System.Drawing.Point(222, 484);
            this.sheet_size.Name = "sheet_size";
            this.sheet_size.Size = new System.Drawing.Size(517, 38);
            this.sheet_size.TabIndex = 245;
            // 
            // SheetSizeLabel
            // 
            this.SheetSizeLabel.AutoSize = true;
            this.SheetSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SheetSizeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetSizeLabel.Location = new System.Drawing.Point(5, 487);
            this.SheetSizeLabel.Name = "SheetSizeLabel";
            this.SheetSizeLabel.Size = new System.Drawing.Size(199, 32);
            this.SheetSizeLabel.TabIndex = 244;
            this.SheetSizeLabel.Text = "Actual Sheet Size";
            // 
            // PaperTypeLabel
            // 
            this.PaperTypeLabel.AutoSize = true;
            this.PaperTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PaperTypeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperTypeLabel.Location = new System.Drawing.Point(5, 443);
            this.PaperTypeLabel.Name = "PaperTypeLabel";
            this.PaperTypeLabel.Size = new System.Drawing.Size(165, 32);
            this.PaperTypeLabel.TabIndex = 243;
            this.PaperTypeLabel.Text = "Type Of Paper";
            // 
            // HorizontalBar3
            // 
            this.HorizontalBar3.BackColor = System.Drawing.Color.LightCyan;
            this.HorizontalBar3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalBar3.Location = new System.Drawing.Point(5, 405);
            this.HorizontalBar3.Name = "HorizontalBar3";
            this.HorizontalBar3.Size = new System.Drawing.Size(750, 2);
            this.HorizontalBar3.TabIndex = 242;
            // 
            // size
            // 
            this.size.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.size.Location = new System.Drawing.Point(222, 364);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(517, 38);
            this.size.TabIndex = 241;
            // 
            // item_code
            // 
            this.item_code.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.item_code.Location = new System.Drawing.Point(222, 320);
            this.item_code.Name = "item_code";
            this.item_code.Size = new System.Drawing.Size(517, 38);
            this.item_code.TabIndex = 240;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.name.Location = new System.Drawing.Point(222, 276);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(517, 38);
            this.name.TabIndex = 239;
            // 
            // party_name
            // 
            this.party_name.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.party_name.Location = new System.Drawing.Point(222, 232);
            this.party_name.Name = "party_name";
            this.party_name.Size = new System.Drawing.Size(517, 38);
            this.party_name.TabIndex = 238;
            // 
            // BoxSizeLabel
            // 
            this.BoxSizeLabel.AutoSize = true;
            this.BoxSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.BoxSizeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSizeLabel.Location = new System.Drawing.Point(3, 367);
            this.BoxSizeLabel.Name = "BoxSizeLabel";
            this.BoxSizeLabel.Size = new System.Drawing.Size(104, 32);
            this.BoxSizeLabel.TabIndex = 237;
            this.BoxSizeLabel.Text = "Box Size";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.BackColor = System.Drawing.Color.Transparent;
            this.JobLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobLabel.Location = new System.Drawing.Point(3, 323);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(115, 32);
            this.JobLabel.TabIndex = 236;
            this.JobLabel.Text = "Job Code";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(3, 279);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(168, 32);
            this.ProductLabel.TabIndex = 235;
            this.ProductLabel.Text = "Product Name";
            // 
            // PartyLabel
            // 
            this.PartyLabel.AutoSize = true;
            this.PartyLabel.BackColor = System.Drawing.Color.Transparent;
            this.PartyLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyLabel.Location = new System.Drawing.Point(3, 235);
            this.PartyLabel.Name = "PartyLabel";
            this.PartyLabel.Size = new System.Drawing.Size(171, 32);
            this.PartyLabel.TabIndex = 234;
            this.PartyLabel.Text = "Name Of Party";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.button1.Location = new System.Drawing.Point(389, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 44);
            this.button1.TabIndex = 261;
            this.button1.Text = "Update Only";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // NewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paper_type);
            this.Controls.Add(this.sr_no);
            this.Controls.Add(this.JobSheetNo);
            this.Controls.Add(this.StatusLabel1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.varnish);
            this.Controls.Add(this.color_shades);
            this.Controls.Add(this.VarnishLabel);
            this.Controls.Add(this.Shade_Nos_Label);
            this.Controls.Add(this.num_of_colors);
            this.Controls.Add(this.ColorsLabel);
            this.Controls.Add(this.cutting_size);
            this.Controls.Add(this.SheetCuttingLabel);
            this.Controls.Add(this.PaperDetails);
            this.Controls.Add(this.sheet_size);
            this.Controls.Add(this.SheetSizeLabel);
            this.Controls.Add(this.PaperTypeLabel);
            this.Controls.Add(this.HorizontalBar3);
            this.Controls.Add(this.size);
            this.Controls.Add(this.item_code);
            this.Controls.Add(this.name);
            this.Controls.Add(this.party_name);
            this.Controls.Add(this.BoxSizeLabel);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.PartyLabel);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(1, 1);
            this.Name = "NewJob";
            this.Size = new System.Drawing.Size(773, 932);
            this.Load += new System.EventHandler(this.NewJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox paper_type;
        private System.Windows.Forms.TextBox sr_no;
        private System.Windows.Forms.Label JobSheetNo;
        private System.Windows.Forms.Label StatusLabel1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox varnish;
        private System.Windows.Forms.TextBox color_shades;
        private System.Windows.Forms.Label VarnishLabel;
        private System.Windows.Forms.Label Shade_Nos_Label;
        private System.Windows.Forms.TextBox num_of_colors;
        private System.Windows.Forms.Label ColorsLabel;
        private System.Windows.Forms.TextBox cutting_size;
        private System.Windows.Forms.Label SheetCuttingLabel;
        private System.Windows.Forms.Label PaperDetails;
        private System.Windows.Forms.TextBox sheet_size;
        private System.Windows.Forms.Label SheetSizeLabel;
        private System.Windows.Forms.Label PaperTypeLabel;
        private System.Windows.Forms.Label HorizontalBar3;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox item_code;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox party_name;
        private System.Windows.Forms.Label BoxSizeLabel;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label PartyLabel;
        private System.Windows.Forms.Button button1;
    }
}