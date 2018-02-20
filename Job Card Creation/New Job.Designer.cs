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
            this.components = new System.ComponentModel.Container();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.HorizontalBar4 = new System.Windows.Forms.Label();
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
            this.JobDetails = new System.Windows.Forms.Label();
            this.HorizontalBar1 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.TextBox();
            this.item_code = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.party_name = new System.Windows.Forms.TextBox();
            this.BoxSizeLabel = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.PartyLabel = new System.Windows.Forms.Label();
            this.sr_no = new System.Windows.Forms.TextBox();
            this.JobSheetNo = new System.Windows.Forms.Label();
            this.paper_type = new System.Windows.Forms.ComboBox();
            this.inventoryDataSet = new Job_Card_Creation.InventoryDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Job_Card_Creation.InventoryDataSetTableAdapters.InventoryTableAdapter();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.JobCardLabel = new System.Windows.Forms.Label();
            this.NewJobLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(5, 666);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(101, 29);
            this.StatusLabel.TabIndex = 92;
            this.StatusLabel.Text = "Status:-";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(6, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 35);
            this.button1.TabIndex = 91;
            this.button1.Text = "Submit Only";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HorizontalBar4
            // 
            this.HorizontalBar4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalBar4.Location = new System.Drawing.Point(3, 654);
            this.HorizontalBar4.Name = "HorizontalBar4";
            this.HorizontalBar4.Size = new System.Drawing.Size(961, 2);
            this.HorizontalBar4.TabIndex = 90;
            // 
            // varnish
            // 
            this.varnish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.varnish.Location = new System.Drawing.Point(237, 566);
            this.varnish.Name = "varnish";
            this.varnish.Size = new System.Drawing.Size(743, 34);
            this.varnish.TabIndex = 89;
            // 
            // color_shades
            // 
            this.color_shades.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.color_shades.Location = new System.Drawing.Point(238, 526);
            this.color_shades.Name = "color_shades";
            this.color_shades.Size = new System.Drawing.Size(743, 34);
            this.color_shades.TabIndex = 88;
            // 
            // VarnishLabel
            // 
            this.VarnishLabel.AutoSize = true;
            this.VarnishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.VarnishLabel.Location = new System.Drawing.Point(7, 569);
            this.VarnishLabel.Name = "VarnishLabel";
            this.VarnishLabel.Size = new System.Drawing.Size(188, 29);
            this.VarnishLabel.TabIndex = 87;
            this.VarnishLabel.Text = "Varnish Details";
            // 
            // Shade_Nos_Label
            // 
            this.Shade_Nos_Label.AutoSize = true;
            this.Shade_Nos_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shade_Nos_Label.Location = new System.Drawing.Point(4, 526);
            this.Shade_Nos_Label.Name = "Shade_Nos_Label";
            this.Shade_Nos_Label.Size = new System.Drawing.Size(172, 29);
            this.Shade_Nos_Label.TabIndex = 86;
            this.Shade_Nos_Label.Text = "Color Shades";
            // 
            // num_of_colors
            // 
            this.num_of_colors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.num_of_colors.Location = new System.Drawing.Point(239, 486);
            this.num_of_colors.Name = "num_of_colors";
            this.num_of_colors.Size = new System.Drawing.Size(743, 34);
            this.num_of_colors.TabIndex = 85;
            // 
            // ColorsLabel
            // 
            this.ColorsLabel.AutoSize = true;
            this.ColorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.ColorsLabel.Location = new System.Drawing.Point(4, 486);
            this.ColorsLabel.Name = "ColorsLabel";
            this.ColorsLabel.Size = new System.Drawing.Size(90, 29);
            this.ColorsLabel.TabIndex = 84;
            this.ColorsLabel.Text = "Colors";
            // 
            // cutting_size
            // 
            this.cutting_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.cutting_size.Location = new System.Drawing.Point(239, 446);
            this.cutting_size.Name = "cutting_size";
            this.cutting_size.Size = new System.Drawing.Size(743, 34);
            this.cutting_size.TabIndex = 83;
            // 
            // SheetCuttingLabel
            // 
            this.SheetCuttingLabel.AutoSize = true;
            this.SheetCuttingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.SheetCuttingLabel.Location = new System.Drawing.Point(0, 446);
            this.SheetCuttingLabel.Name = "SheetCuttingLabel";
            this.SheetCuttingLabel.Size = new System.Drawing.Size(228, 29);
            this.SheetCuttingLabel.TabIndex = 82;
            this.SheetCuttingLabel.Text = "Sheet Cutting Size";
            this.SheetCuttingLabel.Click += new System.EventHandler(this.SheetCuttingLabel_Click);
            // 
            // PaperDetails
            // 
            this.PaperDetails.AutoSize = true;
            this.PaperDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperDetails.Location = new System.Drawing.Point(12, 317);
            this.PaperDetails.Name = "PaperDetails";
            this.PaperDetails.Size = new System.Drawing.Size(205, 36);
            this.PaperDetails.TabIndex = 81;
            this.PaperDetails.Text = "Paper Details";
            // 
            // sheet_size
            // 
            this.sheet_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.sheet_size.Location = new System.Drawing.Point(238, 406);
            this.sheet_size.Name = "sheet_size";
            this.sheet_size.Size = new System.Drawing.Size(743, 34);
            this.sheet_size.TabIndex = 80;
            // 
            // SheetSizeLabel
            // 
            this.SheetSizeLabel.AutoSize = true;
            this.SheetSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.SheetSizeLabel.Location = new System.Drawing.Point(5, 406);
            this.SheetSizeLabel.Name = "SheetSizeLabel";
            this.SheetSizeLabel.Size = new System.Drawing.Size(217, 29);
            this.SheetSizeLabel.TabIndex = 78;
            this.SheetSizeLabel.Text = "Actual Sheet Size";
            // 
            // PaperTypeLabel
            // 
            this.PaperTypeLabel.AutoSize = true;
            this.PaperTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperTypeLabel.Location = new System.Drawing.Point(5, 363);
            this.PaperTypeLabel.Name = "PaperTypeLabel";
            this.PaperTypeLabel.Size = new System.Drawing.Size(183, 29);
            this.PaperTypeLabel.TabIndex = 77;
            this.PaperTypeLabel.Text = "Type Of Paper";
            // 
            // HorizontalBar3
            // 
            this.HorizontalBar3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalBar3.Location = new System.Drawing.Point(10, 306);
            this.HorizontalBar3.Name = "HorizontalBar3";
            this.HorizontalBar3.Size = new System.Drawing.Size(961, 2);
            this.HorizontalBar3.TabIndex = 76;
            // 
            // JobDetails
            // 
            this.JobDetails.AutoSize = true;
            this.JobDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobDetails.Location = new System.Drawing.Point(5, 80);
            this.JobDetails.Name = "JobDetails";
            this.JobDetails.Size = new System.Drawing.Size(173, 36);
            this.JobDetails.TabIndex = 75;
            this.JobDetails.Text = "Job Details";
            // 
            // HorizontalBar1
            // 
            this.HorizontalBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalBar1.Location = new System.Drawing.Point(11, 60);
            this.HorizontalBar1.Name = "HorizontalBar1";
            this.HorizontalBar1.Size = new System.Drawing.Size(961, 2);
            this.HorizontalBar1.TabIndex = 74;
            // 
            // size
            // 
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.size.Location = new System.Drawing.Point(238, 254);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(726, 34);
            this.size.TabIndex = 73;
            // 
            // item_code
            // 
            this.item_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.item_code.Location = new System.Drawing.Point(238, 212);
            this.item_code.Name = "item_code";
            this.item_code.Size = new System.Drawing.Size(726, 34);
            this.item_code.TabIndex = 72;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(238, 172);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(726, 34);
            this.name.TabIndex = 71;
            // 
            // party_name
            // 
            this.party_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.party_name.Location = new System.Drawing.Point(238, 132);
            this.party_name.Name = "party_name";
            this.party_name.Size = new System.Drawing.Size(726, 34);
            this.party_name.TabIndex = 70;
            // 
            // BoxSizeLabel
            // 
            this.BoxSizeLabel.AutoSize = true;
            this.BoxSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.BoxSizeLabel.Location = new System.Drawing.Point(5, 254);
            this.BoxSizeLabel.Name = "BoxSizeLabel";
            this.BoxSizeLabel.Size = new System.Drawing.Size(115, 29);
            this.BoxSizeLabel.TabIndex = 69;
            this.BoxSizeLabel.Text = "Box Size";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.JobLabel.Location = new System.Drawing.Point(5, 212);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(126, 29);
            this.JobLabel.TabIndex = 68;
            this.JobLabel.Text = "Job Code";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.ProductLabel.Location = new System.Drawing.Point(5, 172);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(179, 29);
            this.ProductLabel.TabIndex = 67;
            this.ProductLabel.Text = "Product Name";
            // 
            // PartyLabel
            // 
            this.PartyLabel.AutoSize = true;
            this.PartyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyLabel.Location = new System.Drawing.Point(5, 132);
            this.PartyLabel.Name = "PartyLabel";
            this.PartyLabel.Size = new System.Drawing.Size(182, 29);
            this.PartyLabel.TabIndex = 66;
            this.PartyLabel.Text = "Name Of Party";
            // 
            // sr_no
            // 
            this.sr_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sr_no.Location = new System.Drawing.Point(759, 77);
            this.sr_no.Name = "sr_no";
            this.sr_no.Size = new System.Drawing.Size(208, 41);
            this.sr_no.TabIndex = 95;
            this.sr_no.TextChanged += new System.EventHandler(this.sr_no_TextChanged);
            // 
            // JobSheetNo
            // 
            this.JobSheetNo.AutoSize = true;
            this.JobSheetNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobSheetNo.Location = new System.Drawing.Point(529, 80);
            this.JobSheetNo.Name = "JobSheetNo";
            this.JobSheetNo.Size = new System.Drawing.Size(217, 36);
            this.JobSheetNo.TabIndex = 94;
            this.JobSheetNo.Text = "Job Sheet No.";
            // 
            // paper_type
            // 
            this.paper_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.paper_type.FormattingEnabled = true;
            this.paper_type.Location = new System.Drawing.Point(238, 363);
            this.paper_type.Name = "paper_type";
            this.paper_type.Size = new System.Drawing.Size(743, 37);
            this.paper_type.TabIndex = 96;
            this.paper_type.SelectedIndexChanged += new System.EventHandler(this.paper_type_SelectedIndexChanged);
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.OrderLabel.Location = new System.Drawing.Point(499, 9);
            this.OrderLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(160, 29);
            this.OrderLabel.TabIndex = 100;
            this.OrderLabel.Text = "Order Status";
            this.OrderLabel.Click += new System.EventHandler(this.OrderLabel_Click);
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.InventoryLabel.Location = new System.Drawing.Point(341, 9);
            this.InventoryLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(118, 29);
            this.InventoryLabel.TabIndex = 99;
            this.InventoryLabel.Text = "Inventory";
            this.InventoryLabel.Click += new System.EventHandler(this.InventoryLabel_Click);
            // 
            // JobCardLabel
            // 
            this.JobCardLabel.AutoSize = true;
            this.JobCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.JobCardLabel.Location = new System.Drawing.Point(169, 9);
            this.JobCardLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.JobCardLabel.Name = "JobCardLabel";
            this.JobCardLabel.Size = new System.Drawing.Size(132, 29);
            this.JobCardLabel.TabIndex = 98;
            this.JobCardLabel.Text = "Job Cards";
            this.JobCardLabel.Click += new System.EventHandler(this.JobCardLabel_Click);
            // 
            // NewJobLabel
            // 
            this.NewJobLabel.AutoSize = true;
            this.NewJobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.NewJobLabel.Location = new System.Drawing.Point(13, 9);
            this.NewJobLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.NewJobLabel.Name = "NewJobLabel";
            this.NewJobLabel.Size = new System.Drawing.Size(116, 29);
            this.NewJobLabel.TabIndex = 97;
            this.NewJobLabel.Text = "New Job";
            this.NewJobLabel.Click += new System.EventHandler(this.NewJob_Click);
            // 
            // NewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 704);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.JobCardLabel);
            this.Controls.Add(this.NewJobLabel);
            this.Controls.Add(this.paper_type);
            this.Controls.Add(this.sr_no);
            this.Controls.Add(this.JobSheetNo);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HorizontalBar4);
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
            this.Controls.Add(this.JobDetails);
            this.Controls.Add(this.HorizontalBar1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.item_code);
            this.Controls.Add(this.name);
            this.Controls.Add(this.party_name);
            this.Controls.Add(this.BoxSizeLabel);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.PartyLabel);
            this.Location = new System.Drawing.Point(30, 30);
            this.Name = "NewJob";
            this.Text = "New_Job";
            this.Load += new System.EventHandler(this.NewJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label HorizontalBar4;
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
        private System.Windows.Forms.Label JobDetails;
        private System.Windows.Forms.Label HorizontalBar1;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox item_code;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox party_name;
        private System.Windows.Forms.Label BoxSizeLabel;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label PartyLabel;
        private System.Windows.Forms.TextBox sr_no;
        private System.Windows.Forms.Label JobSheetNo;
        private System.Windows.Forms.ComboBox paper_type;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private InventoryDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label JobCardLabel;
        private System.Windows.Forms.Label NewJobLabel;
    }
}