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
            this.radioHigh = new System.Windows.Forms.RadioButton();
            this.radioLow = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioImmediate = new System.Windows.Forms.RadioButton();
            this.radioDelayed = new System.Windows.Forms.RadioButton();
            this.PriorityGroup = new System.Windows.Forms.GroupBox();
            this.StatusGroup = new System.Windows.Forms.GroupBox();
            this.StatusReady = new System.Windows.Forms.RadioButton();
            this.StatusPrinting = new System.Windows.Forms.RadioButton();
            this.StatusDispatched = new System.Windows.Forms.RadioButton();
            this.StatusConfirmed = new System.Windows.Forms.RadioButton();
            this.StatusReceived = new System.Windows.Forms.RadioButton();
            this.StatusDelayed = new System.Windows.Forms.RadioButton();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.Comments = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 53);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info1.Location = new System.Drawing.Point(13, 72);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(292, 25);
            this.Info1.TabIndex = 1;
            this.Info1.Text = "Click on a row in the table to Edit";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(871, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 22);
            this.dateTimePicker1.TabIndex = 74;
            this.dateTimePicker1.Visible = false;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(811, 183);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(230, 34);
            this.date.TabIndex = 73;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(749, 187);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(57, 25);
            this.DateLabel.TabIndex = 72;
            this.DateLabel.Text = "Date";
            // 
            // item_code
            // 
            this.item_code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.item_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.item_code.Location = new System.Drawing.Point(203, 100);
            this.item_code.Name = "item_code";
            this.item_code.Size = new System.Drawing.Size(545, 34);
            this.item_code.TabIndex = 71;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(203, 140);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(545, 34);
            this.name.TabIndex = 70;
            // 
            // party_name
            // 
            this.party_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.party_name.Location = new System.Drawing.Point(203, 180);
            this.party_name.Name = "party_name";
            this.party_name.Size = new System.Drawing.Size(545, 34);
            this.party_name.TabIndex = 69;
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.JobLabel.Location = new System.Drawing.Point(21, 103);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(126, 29);
            this.JobLabel.TabIndex = 68;
            this.JobLabel.Text = "Job Code";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.ProductLabel.Location = new System.Drawing.Point(21, 143);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(179, 29);
            this.ProductLabel.TabIndex = 67;
            this.ProductLabel.Text = "Product Name";
            // 
            // PartyLabel
            // 
            this.PartyLabel.AutoSize = true;
            this.PartyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyLabel.Location = new System.Drawing.Point(21, 183);
            this.PartyLabel.Name = "PartyLabel";
            this.PartyLabel.Size = new System.Drawing.Size(182, 29);
            this.PartyLabel.TabIndex = 66;
            this.PartyLabel.Text = "Name Of Party";
            // 
            // radioHigh
            // 
            this.radioHigh.AutoSize = true;
            this.radioHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHigh.Location = new System.Drawing.Point(9, 33);
            this.radioHigh.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.radioHigh.Name = "radioHigh";
            this.radioHigh.Size = new System.Drawing.Size(65, 24);
            this.radioHigh.TabIndex = 78;
            this.radioHigh.TabStop = true;
            this.radioHigh.Text = "High";
            this.radioHigh.UseVisualStyleBackColor = true;
            // 
            // radioLow
            // 
            this.radioLow.AutoSize = true;
            this.radioLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLow.Location = new System.Drawing.Point(187, 33);
            this.radioLow.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.radioLow.Name = "radioLow";
            this.radioLow.Size = new System.Drawing.Size(61, 24);
            this.radioLow.TabIndex = 79;
            this.radioLow.TabStop = true;
            this.radioLow.Text = "Low";
            this.radioLow.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMedium.Location = new System.Drawing.Point(86, 33);
            this.radioMedium.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(89, 24);
            this.radioMedium.TabIndex = 80;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioImmediate
            // 
            this.radioImmediate.AutoSize = true;
            this.radioImmediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioImmediate.Location = new System.Drawing.Point(260, 33);
            this.radioImmediate.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.radioImmediate.Name = "radioImmediate";
            this.radioImmediate.Size = new System.Drawing.Size(112, 24);
            this.radioImmediate.TabIndex = 81;
            this.radioImmediate.TabStop = true;
            this.radioImmediate.Text = "Immediate!";
            this.radioImmediate.UseVisualStyleBackColor = true;
            this.radioImmediate.CheckedChanged += new System.EventHandler(this.radioImmediate_CheckedChanged);
            // 
            // radioDelayed
            // 
            this.radioDelayed.AutoSize = true;
            this.radioDelayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDelayed.Location = new System.Drawing.Point(384, 33);
            this.radioDelayed.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.radioDelayed.Name = "radioDelayed";
            this.radioDelayed.Size = new System.Drawing.Size(91, 24);
            this.radioDelayed.TabIndex = 82;
            this.radioDelayed.TabStop = true;
            this.radioDelayed.Text = "Delayed";
            this.radioDelayed.UseVisualStyleBackColor = true;
            // 
            // PriorityGroup
            // 
            this.PriorityGroup.Controls.Add(this.radioImmediate);
            this.PriorityGroup.Controls.Add(this.radioDelayed);
            this.PriorityGroup.Controls.Add(this.radioHigh);
            this.PriorityGroup.Controls.Add(this.radioLow);
            this.PriorityGroup.Controls.Add(this.radioMedium);
            this.PriorityGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityGroup.Location = new System.Drawing.Point(18, 312);
            this.PriorityGroup.Name = "PriorityGroup";
            this.PriorityGroup.Size = new System.Drawing.Size(661, 83);
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
            this.StatusGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusGroup.Location = new System.Drawing.Point(18, 220);
            this.StatusGroup.Name = "StatusGroup";
            this.StatusGroup.Size = new System.Drawing.Size(677, 86);
            this.StatusGroup.TabIndex = 84;
            this.StatusGroup.TabStop = false;
            this.StatusGroup.Text = "Status";
            // 
            // StatusReady
            // 
            this.StatusReady.AutoSize = true;
            this.StatusReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusReady.Location = new System.Drawing.Point(350, 33);
            this.StatusReady.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusReady.Name = "StatusReady";
            this.StatusReady.Size = new System.Drawing.Size(77, 24);
            this.StatusReady.TabIndex = 86;
            this.StatusReady.TabStop = true;
            this.StatusReady.Text = "Ready";
            this.StatusReady.UseVisualStyleBackColor = true;
            this.StatusReady.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // StatusPrinting
            // 
            this.StatusPrinting.AutoSize = true;
            this.StatusPrinting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusPrinting.Location = new System.Drawing.Point(247, 33);
            this.StatusPrinting.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusPrinting.Name = "StatusPrinting";
            this.StatusPrinting.Size = new System.Drawing.Size(87, 24);
            this.StatusPrinting.TabIndex = 84;
            this.StatusPrinting.TabStop = true;
            this.StatusPrinting.Text = "Printing";
            this.StatusPrinting.UseVisualStyleBackColor = true;
            this.StatusPrinting.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // StatusDispatched
            // 
            this.StatusDispatched.AutoSize = true;
            this.StatusDispatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusDispatched.Location = new System.Drawing.Point(443, 33);
            this.StatusDispatched.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusDispatched.Name = "StatusDispatched";
            this.StatusDispatched.Size = new System.Drawing.Size(115, 24);
            this.StatusDispatched.TabIndex = 87;
            this.StatusDispatched.TabStop = true;
            this.StatusDispatched.Text = "Dispatched";
            this.StatusDispatched.UseVisualStyleBackColor = true;
            this.StatusDispatched.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // StatusConfirmed
            // 
            this.StatusConfirmed.AutoSize = true;
            this.StatusConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusConfirmed.Location = new System.Drawing.Point(124, 33);
            this.StatusConfirmed.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusConfirmed.Name = "StatusConfirmed";
            this.StatusConfirmed.Size = new System.Drawing.Size(107, 24);
            this.StatusConfirmed.TabIndex = 85;
            this.StatusConfirmed.TabStop = true;
            this.StatusConfirmed.Text = "Confirmed";
            this.StatusConfirmed.UseVisualStyleBackColor = true;
            this.StatusConfirmed.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // StatusReceived
            // 
            this.StatusReceived.AutoSize = true;
            this.StatusReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusReceived.Location = new System.Drawing.Point(9, 33);
            this.StatusReceived.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusReceived.Name = "StatusReceived";
            this.StatusReceived.Size = new System.Drawing.Size(99, 24);
            this.StatusReceived.TabIndex = 83;
            this.StatusReceived.TabStop = true;
            this.StatusReceived.Text = "Received";
            this.StatusReceived.UseVisualStyleBackColor = true;
            // 
            // StatusDelayed
            // 
            this.StatusDelayed.AutoSize = true;
            this.StatusDelayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusDelayed.Location = new System.Drawing.Point(574, 33);
            this.StatusDelayed.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusDelayed.Name = "StatusDelayed";
            this.StatusDelayed.Size = new System.Drawing.Size(91, 24);
            this.StatusDelayed.TabIndex = 88;
            this.StatusDelayed.TabStop = true;
            this.StatusDelayed.Text = "Delayed";
            this.StatusDelayed.UseVisualStyleBackColor = true;
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLabel.Location = new System.Drawing.Point(18, 398);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(137, 29);
            this.CommentsLabel.TabIndex = 86;
            this.CommentsLabel.Text = "Comments";
            this.CommentsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Comments
            // 
            this.Comments.Location = new System.Drawing.Point(18, 431);
            this.Comments.Multiline = true;
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(786, 124);
            this.Comments.TabIndex = 87;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(18, 586);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(183, 31);
            this.AddButton.TabIndex = 89;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(207, 586);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(183, 31);
            this.UpdateButton.TabIndex = 90;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(396, 586);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(183, 31);
            this.ClearButton.TabIndex = 91;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(13, 629);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(101, 29);
            this.StatusLabel.TabIndex = 92;
            this.StatusLabel.Text = "Status:-";
            // 
            // OrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 803);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
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
            this.Name = "OrderStatus";
            this.Text = "Order Status";
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
        private System.Windows.Forms.RadioButton radioHigh;
        private System.Windows.Forms.RadioButton radioLow;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioImmediate;
        private System.Windows.Forms.RadioButton radioDelayed;
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
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}