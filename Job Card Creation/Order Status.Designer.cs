namespace Job_Card_Creation
{
    partial class OrderStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Job_Card_Creation.Database1DataSet();
            this.order_statusTableAdapter = new Job_Card_Creation.Database1DataSetTableAdapters.order_statusTableAdapter();
            this.Info1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.item_code = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.party_name = new System.Windows.Forms.TextBox();
            this.JobLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.PartyLabel = new System.Windows.Forms.Label();
            this.PriorityHigh = new System.Windows.Forms.RadioButton();
            this.PriorityLow = new System.Windows.Forms.RadioButton();
            this.PriorityMedium = new System.Windows.Forms.RadioButton();
            this.PriorityImmediate = new System.Windows.Forms.RadioButton();
            this.PriorityDelayed = new System.Windows.Forms.RadioButton();
            this.PriorityGroup = new System.Windows.Forms.GroupBox();
            this.StatusGroup = new System.Windows.Forms.GroupBox();
            this.StatusDelayed = new System.Windows.Forms.RadioButton();
            this.StatusReady = new System.Windows.Forms.RadioButton();
            this.StatusPrinting = new System.Windows.Forms.RadioButton();
            this.StatusDispatched = new System.Windows.Forms.RadioButton();
            this.StatusConfirmed = new System.Windows.Forms.RadioButton();
            this.StatusReceived = new System.Windows.Forms.RadioButton();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.Comments = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.var_priority = new System.Windows.Forms.Label();
            this.var_status = new System.Windows.Forms.Label();
            this.sr_no = new System.Windows.Forms.TextBox();
            this.SrNoLabel = new System.Windows.Forms.Label();
            this.HorizontalBar4 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderstatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.PriorityGroup.SuspendLayout();
            this.StatusGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // orderstatusBindingSource
            // 
            this.orderstatusBindingSource.DataMember = "order_status";
            this.orderstatusBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_statusTableAdapter
            // 
            this.order_statusTableAdapter.ClearBeforeFill = true;
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Info1.Location = new System.Drawing.Point(3, 197);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(300, 28);
            this.Info1.TabIndex = 1;
            this.Info1.Text = "Click on a row in the table to Edit";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(490, 581);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 38);
            this.dateTimePicker1.TabIndex = 74;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(243, 569);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(230, 34);
            this.date.TabIndex = 73;
            this.date.TextChanged += new System.EventHandler(this.date_TextChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(9, 574);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(226, 32);
            this.DateLabel.TabIndex = 72;
            this.DateLabel.Text = "Date of Last Update";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // item_code
            // 
            this.item_code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.item_code.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.item_code.Location = new System.Drawing.Point(226, 260);
            this.item_code.Name = "item_code";
            this.item_code.Size = new System.Drawing.Size(523, 38);
            this.item_code.TabIndex = 71;
            this.item_code.TextChanged += new System.EventHandler(this.item_code_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.name.Location = new System.Drawing.Point(226, 304);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(523, 38);
            this.name.TabIndex = 70;
            // 
            // party_name
            // 
            this.party_name.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.party_name.Location = new System.Drawing.Point(226, 348);
            this.party_name.Name = "party_name";
            this.party_name.Size = new System.Drawing.Size(523, 38);
            this.party_name.TabIndex = 69;
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobLabel.Location = new System.Drawing.Point(16, 263);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(115, 32);
            this.JobLabel.TabIndex = 68;
            this.JobLabel.Text = "Job Code";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(16, 307);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(168, 32);
            this.ProductLabel.TabIndex = 67;
            this.ProductLabel.Text = "Product Name";
            // 
            // PartyLabel
            // 
            this.PartyLabel.AutoSize = true;
            this.PartyLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyLabel.Location = new System.Drawing.Point(16, 351);
            this.PartyLabel.Name = "PartyLabel";
            this.PartyLabel.Size = new System.Drawing.Size(171, 32);
            this.PartyLabel.TabIndex = 66;
            this.PartyLabel.Text = "Name Of Party";
            // 
            // PriorityHigh
            // 
            this.PriorityHigh.AutoSize = true;
            this.PriorityHigh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityHigh.Location = new System.Drawing.Point(9, 33);
            this.PriorityHigh.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.PriorityHigh.Name = "PriorityHigh";
            this.PriorityHigh.Size = new System.Drawing.Size(67, 27);
            this.PriorityHigh.TabIndex = 78;
            this.PriorityHigh.TabStop = true;
            this.PriorityHigh.Text = "High";
            this.PriorityHigh.UseVisualStyleBackColor = true;
            // 
            // PriorityLow
            // 
            this.PriorityLow.AutoSize = true;
            this.PriorityLow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityLow.Location = new System.Drawing.Point(187, 33);
            this.PriorityLow.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.PriorityLow.Name = "PriorityLow";
            this.PriorityLow.Size = new System.Drawing.Size(61, 27);
            this.PriorityLow.TabIndex = 79;
            this.PriorityLow.TabStop = true;
            this.PriorityLow.Text = "Low";
            this.PriorityLow.UseVisualStyleBackColor = true;
            // 
            // PriorityMedium
            // 
            this.PriorityMedium.AutoSize = true;
            this.PriorityMedium.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityMedium.Location = new System.Drawing.Point(86, 33);
            this.PriorityMedium.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.PriorityMedium.Name = "PriorityMedium";
            this.PriorityMedium.Size = new System.Drawing.Size(94, 27);
            this.PriorityMedium.TabIndex = 80;
            this.PriorityMedium.TabStop = true;
            this.PriorityMedium.Text = "Medium";
            this.PriorityMedium.UseVisualStyleBackColor = true;
            // 
            // PriorityImmediate
            // 
            this.PriorityImmediate.AutoSize = true;
            this.PriorityImmediate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityImmediate.Location = new System.Drawing.Point(260, 33);
            this.PriorityImmediate.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.PriorityImmediate.Name = "PriorityImmediate";
            this.PriorityImmediate.Size = new System.Drawing.Size(118, 27);
            this.PriorityImmediate.TabIndex = 81;
            this.PriorityImmediate.TabStop = true;
            this.PriorityImmediate.Text = "Immediate!";
            this.PriorityImmediate.UseVisualStyleBackColor = true;
            this.PriorityImmediate.CheckedChanged += new System.EventHandler(this.radioImmediate_CheckedChanged);
            // 
            // PriorityDelayed
            // 
            this.PriorityDelayed.AutoSize = true;
            this.PriorityDelayed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityDelayed.Location = new System.Drawing.Point(384, 33);
            this.PriorityDelayed.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.PriorityDelayed.Name = "PriorityDelayed";
            this.PriorityDelayed.Size = new System.Drawing.Size(92, 27);
            this.PriorityDelayed.TabIndex = 82;
            this.PriorityDelayed.TabStop = true;
            this.PriorityDelayed.Text = "Delayed";
            this.PriorityDelayed.UseVisualStyleBackColor = true;
            // 
            // PriorityGroup
            // 
            this.PriorityGroup.Controls.Add(this.PriorityImmediate);
            this.PriorityGroup.Controls.Add(this.PriorityDelayed);
            this.PriorityGroup.Controls.Add(this.PriorityHigh);
            this.PriorityGroup.Controls.Add(this.PriorityLow);
            this.PriorityGroup.Controls.Add(this.PriorityMedium);
            this.PriorityGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityGroup.Location = new System.Drawing.Point(13, 480);
            this.PriorityGroup.Name = "PriorityGroup";
            this.PriorityGroup.Size = new System.Drawing.Size(489, 83);
            this.PriorityGroup.TabIndex = 83;
            this.PriorityGroup.TabStop = false;
            this.PriorityGroup.Text = "Priority";
            // 
            // StatusGroup
            // 
            this.StatusGroup.Controls.Add(this.StatusDelayed);
            this.StatusGroup.Controls.Add(this.StatusReady);
            this.StatusGroup.Controls.Add(this.StatusPrinting);
            this.StatusGroup.Controls.Add(this.StatusDispatched);
            this.StatusGroup.Controls.Add(this.StatusConfirmed);
            this.StatusGroup.Controls.Add(this.StatusReceived);
            this.StatusGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusGroup.Location = new System.Drawing.Point(13, 388);
            this.StatusGroup.Name = "StatusGroup";
            this.StatusGroup.Size = new System.Drawing.Size(677, 86);
            this.StatusGroup.TabIndex = 84;
            this.StatusGroup.TabStop = false;
            this.StatusGroup.Text = "Status";
            this.StatusGroup.Enter += new System.EventHandler(this.StatusGroup_Enter);
            // 
            // StatusDelayed
            // 
            this.StatusDelayed.AutoSize = true;
            this.StatusDelayed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusDelayed.Location = new System.Drawing.Point(574, 33);
            this.StatusDelayed.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusDelayed.Name = "StatusDelayed";
            this.StatusDelayed.Size = new System.Drawing.Size(92, 27);
            this.StatusDelayed.TabIndex = 88;
            this.StatusDelayed.TabStop = true;
            this.StatusDelayed.Text = "Delayed";
            this.StatusDelayed.UseVisualStyleBackColor = true;
            // 
            // StatusReady
            // 
            this.StatusReady.AutoSize = true;
            this.StatusReady.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusReady.Location = new System.Drawing.Point(350, 33);
            this.StatusReady.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusReady.Name = "StatusReady";
            this.StatusReady.Size = new System.Drawing.Size(77, 27);
            this.StatusReady.TabIndex = 86;
            this.StatusReady.TabStop = true;
            this.StatusReady.Text = "Ready";
            this.StatusReady.UseVisualStyleBackColor = true;
            this.StatusReady.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // StatusPrinting
            // 
            this.StatusPrinting.AutoSize = true;
            this.StatusPrinting.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusPrinting.Location = new System.Drawing.Point(247, 33);
            this.StatusPrinting.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusPrinting.Name = "StatusPrinting";
            this.StatusPrinting.Size = new System.Drawing.Size(91, 27);
            this.StatusPrinting.TabIndex = 84;
            this.StatusPrinting.TabStop = true;
            this.StatusPrinting.Text = "Printing";
            this.StatusPrinting.UseVisualStyleBackColor = true;
            this.StatusPrinting.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // StatusDispatched
            // 
            this.StatusDispatched.AutoSize = true;
            this.StatusDispatched.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusDispatched.Location = new System.Drawing.Point(443, 33);
            this.StatusDispatched.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusDispatched.Name = "StatusDispatched";
            this.StatusDispatched.Size = new System.Drawing.Size(116, 27);
            this.StatusDispatched.TabIndex = 87;
            this.StatusDispatched.TabStop = true;
            this.StatusDispatched.Text = "Dispatched";
            this.StatusDispatched.UseVisualStyleBackColor = true;
            this.StatusDispatched.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // StatusConfirmed
            // 
            this.StatusConfirmed.AutoSize = true;
            this.StatusConfirmed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusConfirmed.Location = new System.Drawing.Point(124, 33);
            this.StatusConfirmed.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusConfirmed.Name = "StatusConfirmed";
            this.StatusConfirmed.Size = new System.Drawing.Size(111, 27);
            this.StatusConfirmed.TabIndex = 85;
            this.StatusConfirmed.TabStop = true;
            this.StatusConfirmed.Text = "Confirmed";
            this.StatusConfirmed.UseVisualStyleBackColor = true;
            this.StatusConfirmed.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // StatusReceived
            // 
            this.StatusReceived.AutoSize = true;
            this.StatusReceived.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusReceived.Location = new System.Drawing.Point(9, 33);
            this.StatusReceived.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusReceived.Name = "StatusReceived";
            this.StatusReceived.Size = new System.Drawing.Size(98, 27);
            this.StatusReceived.TabIndex = 83;
            this.StatusReceived.TabStop = true;
            this.StatusReceived.Text = "Received";
            this.StatusReceived.UseVisualStyleBackColor = true;
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLabel.Location = new System.Drawing.Point(13, 601);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(131, 32);
            this.CommentsLabel.TabIndex = 86;
            this.CommentsLabel.Text = "Comments";
            this.CommentsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Comments
            // 
            this.Comments.Location = new System.Drawing.Point(13, 634);
            this.Comments.Multiline = true;
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(736, 38);
            this.Comments.TabIndex = 87;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(2, 891);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(101, 32);
            this.StatusLabel.TabIndex = 92;
            this.StatusLabel.Text = "Status: -";
            // 
            // var_priority
            // 
            this.var_priority.AutoSize = true;
            this.var_priority.Location = new System.Drawing.Point(306, 226);
            this.var_priority.Name = "var_priority";
            this.var_priority.Size = new System.Drawing.Size(79, 17);
            this.var_priority.TabIndex = 94;
            this.var_priority.Text = "var_priority";
            this.var_priority.Visible = false;
            this.var_priority.Click += new System.EventHandler(this.priority_Click);
            // 
            // var_status
            // 
            this.var_status.AutoSize = true;
            this.var_status.Location = new System.Drawing.Point(306, 209);
            this.var_status.Name = "var_status";
            this.var_status.Size = new System.Drawing.Size(74, 17);
            this.var_status.TabIndex = 95;
            this.var_status.Text = "var_status";
            this.var_status.Visible = false;
            // 
            // sr_no
            // 
            this.sr_no.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sr_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.sr_no.Location = new System.Drawing.Point(104, 226);
            this.sr_no.Name = "sr_no";
            this.sr_no.ReadOnly = true;
            this.sr_no.Size = new System.Drawing.Size(108, 34);
            this.sr_no.TabIndex = 96;
            // 
            // SrNoLabel
            // 
            this.SrNoLabel.AutoSize = true;
            this.SrNoLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrNoLabel.Location = new System.Drawing.Point(11, 229);
            this.SrNoLabel.Name = "SrNoLabel";
            this.SrNoLabel.Size = new System.Drawing.Size(80, 32);
            this.SrNoLabel.TabIndex = 97;
            this.SrNoLabel.Text = "Sr. No";
            // 
            // HorizontalBar4
            // 
            this.HorizontalBar4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalBar4.Location = new System.Drawing.Point(4, 889);
            this.HorizontalBar4.Name = "HorizontalBar4";
            this.HorizontalBar4.Size = new System.Drawing.Size(765, 2);
            this.HorizontalBar4.TabIndex = 102;
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.BackColor = System.Drawing.Color.White;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(179, 678);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(183, 44);
            this.UpdateButton.TabIndex = 90;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(397, 678);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(183, 44);
            this.ClearButton.TabIndex = 91;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.HorizontalBar4);
            this.Controls.Add(this.SrNoLabel);
            this.Controls.Add(this.sr_no);
            this.Controls.Add(this.var_status);
            this.Controls.Add(this.var_priority);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.CommentsLabel);
            this.Controls.Add(this.StatusGroup);
            this.Controls.Add(this.PriorityGroup);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.item_code);
            this.Controls.Add(this.name);
            this.Controls.Add(this.party_name);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.PartyLabel);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(1, 1);
            this.Name = "OrderStatus";
            this.Size = new System.Drawing.Size(773, 932);
            this.Load += new System.EventHandler(this.OrderStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderstatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.PriorityGroup.ResumeLayout(false);
            this.PriorityGroup.PerformLayout();
            this.StatusGroup.ResumeLayout(false);
            this.StatusGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource orderstatusBindingSource;
        private Database1DataSetTableAdapters.order_statusTableAdapter order_statusTableAdapter;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox item_code;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox party_name;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label PartyLabel;
        private System.Windows.Forms.RadioButton PriorityHigh;
        private System.Windows.Forms.RadioButton PriorityLow;
        private System.Windows.Forms.RadioButton PriorityMedium;
        private System.Windows.Forms.RadioButton PriorityImmediate;
        private System.Windows.Forms.RadioButton PriorityDelayed;
        private System.Windows.Forms.GroupBox PriorityGroup;
        private System.Windows.Forms.GroupBox StatusGroup;
        private System.Windows.Forms.RadioButton StatusReady;
        private System.Windows.Forms.RadioButton StatusPrinting;
        private System.Windows.Forms.RadioButton StatusDispatched;
        private System.Windows.Forms.RadioButton StatusConfirmed;
        private System.Windows.Forms.RadioButton StatusReceived;
        private System.Windows.Forms.RadioButton StatusDelayed;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label var_priority;
        private System.Windows.Forms.Label var_status;
        private System.Windows.Forms.TextBox sr_no;
        private System.Windows.Forms.Label SrNoLabel;
        private System.Windows.Forms.Label HorizontalBar4;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
    }
}