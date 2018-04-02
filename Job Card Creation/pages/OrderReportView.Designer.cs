namespace Job_Card_Creation.pages
{
    partial class OrderReportView
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
            this.FieldSelectButton = new System.Windows.Forms.Button();
            this.FieldSelectButton1 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.StatusReportButton = new System.Windows.Forms.Button();
            this.PriorityReportButton = new System.Windows.Forms.Button();
            this.StatusLabel1 = new System.Windows.Forms.Label();
            this.StatusGroup = new System.Windows.Forms.GroupBox();
            this.StatusDelayed = new System.Windows.Forms.RadioButton();
            this.StatusReady = new System.Windows.Forms.RadioButton();
            this.StatusPrinting = new System.Windows.Forms.RadioButton();
            this.StatusDispatched = new System.Windows.Forms.RadioButton();
            this.StatusConfirmed = new System.Windows.Forms.RadioButton();
            this.StatusReceived = new System.Windows.Forms.RadioButton();
            this.PriorityGroup = new System.Windows.Forms.GroupBox();
            this.PriorityImmediate = new System.Windows.Forms.RadioButton();
            this.PriorityDelayed = new System.Windows.Forms.RadioButton();
            this.PriorityHigh = new System.Windows.Forms.RadioButton();
            this.PriorityLow = new System.Windows.Forms.RadioButton();
            this.PriorityMedium = new System.Windows.Forms.RadioButton();
            this.StatusGroup.SuspendLayout();
            this.PriorityGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FieldSelectButton
            // 
            this.FieldSelectButton.AutoSize = true;
            this.FieldSelectButton.BackColor = System.Drawing.Color.White;
            this.FieldSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FieldSelectButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.FieldSelectButton.Location = new System.Drawing.Point(12, 882);
            this.FieldSelectButton.Name = "FieldSelectButton";
            this.FieldSelectButton.Size = new System.Drawing.Size(183, 44);
            this.FieldSelectButton.TabIndex = 102;
            this.FieldSelectButton.Text = "Choose Fields";
            this.FieldSelectButton.UseVisualStyleBackColor = false;
            // 
            // FieldSelectButton1
            // 
            this.FieldSelectButton1.AutoSize = true;
            this.FieldSelectButton1.BackColor = System.Drawing.Color.White;
            this.FieldSelectButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FieldSelectButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.FieldSelectButton1.Location = new System.Drawing.Point(12, 882);
            this.FieldSelectButton1.Name = "FieldSelectButton1";
            this.FieldSelectButton1.Size = new System.Drawing.Size(183, 44);
            this.FieldSelectButton1.TabIndex = 103;
            this.FieldSelectButton1.Text = "Choose Fields";
            this.FieldSelectButton1.UseVisualStyleBackColor = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(927, 527);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // StatusReportButton
            // 
            this.StatusReportButton.AutoSize = true;
            this.StatusReportButton.BackColor = System.Drawing.Color.White;
            this.StatusReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusReportButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusReportButton.Location = new System.Drawing.Point(12, 545);
            this.StatusReportButton.Name = "StatusReportButton";
            this.StatusReportButton.Size = new System.Drawing.Size(183, 44);
            this.StatusReportButton.TabIndex = 104;
            this.StatusReportButton.Text = "Status Report";
            this.StatusReportButton.UseVisualStyleBackColor = false;
            this.StatusReportButton.Click += new System.EventHandler(this.StatusReportButton_Click);
            // 
            // PriorityReportButton
            // 
            this.PriorityReportButton.AutoSize = true;
            this.PriorityReportButton.BackColor = System.Drawing.Color.White;
            this.PriorityReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriorityReportButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityReportButton.Location = new System.Drawing.Point(12, 618);
            this.PriorityReportButton.Name = "PriorityReportButton";
            this.PriorityReportButton.Size = new System.Drawing.Size(183, 44);
            this.PriorityReportButton.TabIndex = 105;
            this.PriorityReportButton.Text = "Priority Report";
            this.PriorityReportButton.UseVisualStyleBackColor = false;
            this.PriorityReportButton.Click += new System.EventHandler(this.PriorityReportButton_Click);
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.AutoSize = true;
            this.StatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel1.Location = new System.Drawing.Point(6, 665);
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(101, 32);
            this.StatusLabel1.TabIndex = 259;
            this.StatusLabel1.Text = "Status: -";
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
            this.StatusGroup.Location = new System.Drawing.Point(241, 533);
            this.StatusGroup.Name = "StatusGroup";
            this.StatusGroup.Size = new System.Drawing.Size(571, 70);
            this.StatusGroup.TabIndex = 260;
            this.StatusGroup.TabStop = false;
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
            this.StatusReady.Location = new System.Drawing.Point(350, 29);
            this.StatusReady.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusReady.Name = "StatusReady";
            this.StatusReady.Size = new System.Drawing.Size(77, 27);
            this.StatusReady.TabIndex = 86;
            this.StatusReady.TabStop = true;
            this.StatusReady.Text = "Ready";
            this.StatusReady.UseVisualStyleBackColor = true;
            // 
            // StatusPrinting
            // 
            this.StatusPrinting.AutoSize = true;
            this.StatusPrinting.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusPrinting.Location = new System.Drawing.Point(243, 29);
            this.StatusPrinting.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusPrinting.Name = "StatusPrinting";
            this.StatusPrinting.Size = new System.Drawing.Size(91, 27);
            this.StatusPrinting.TabIndex = 84;
            this.StatusPrinting.TabStop = true;
            this.StatusPrinting.Text = "Printing";
            this.StatusPrinting.UseVisualStyleBackColor = true;
            // 
            // StatusDispatched
            // 
            this.StatusDispatched.AutoSize = true;
            this.StatusDispatched.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusDispatched.Location = new System.Drawing.Point(443, 31);
            this.StatusDispatched.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusDispatched.Name = "StatusDispatched";
            this.StatusDispatched.Size = new System.Drawing.Size(116, 27);
            this.StatusDispatched.TabIndex = 87;
            this.StatusDispatched.TabStop = true;
            this.StatusDispatched.Text = "Dispatched";
            this.StatusDispatched.UseVisualStyleBackColor = true;
            // 
            // StatusConfirmed
            // 
            this.StatusConfirmed.AutoSize = true;
            this.StatusConfirmed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusConfirmed.Location = new System.Drawing.Point(123, 29);
            this.StatusConfirmed.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusConfirmed.Name = "StatusConfirmed";
            this.StatusConfirmed.Size = new System.Drawing.Size(111, 27);
            this.StatusConfirmed.TabIndex = 85;
            this.StatusConfirmed.TabStop = true;
            this.StatusConfirmed.Text = "Confirmed";
            this.StatusConfirmed.UseVisualStyleBackColor = true;
            // 
            // StatusReceived
            // 
            this.StatusReceived.AutoSize = true;
            this.StatusReceived.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusReceived.Location = new System.Drawing.Point(9, 29);
            this.StatusReceived.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.StatusReceived.Name = "StatusReceived";
            this.StatusReceived.Size = new System.Drawing.Size(98, 27);
            this.StatusReceived.TabIndex = 83;
            this.StatusReceived.TabStop = true;
            this.StatusReceived.Text = "Received";
            this.StatusReceived.UseVisualStyleBackColor = true;
            // 
            // PriorityGroup
            // 
            this.PriorityGroup.Controls.Add(this.PriorityImmediate);
            this.PriorityGroup.Controls.Add(this.PriorityDelayed);
            this.PriorityGroup.Controls.Add(this.PriorityHigh);
            this.PriorityGroup.Controls.Add(this.PriorityLow);
            this.PriorityGroup.Controls.Add(this.PriorityMedium);
            this.PriorityGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityGroup.Location = new System.Drawing.Point(241, 609);
            this.PriorityGroup.Name = "PriorityGroup";
            this.PriorityGroup.Size = new System.Drawing.Size(571, 62);
            this.PriorityGroup.TabIndex = 261;
            this.PriorityGroup.TabStop = false;
            // 
            // PriorityImmediate
            // 
            this.PriorityImmediate.AutoSize = true;
            this.PriorityImmediate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityImmediate.Location = new System.Drawing.Point(260, 21);
            this.PriorityImmediate.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.PriorityImmediate.Name = "PriorityImmediate";
            this.PriorityImmediate.Size = new System.Drawing.Size(118, 27);
            this.PriorityImmediate.TabIndex = 81;
            this.PriorityImmediate.TabStop = true;
            this.PriorityImmediate.Text = "Immediate!";
            this.PriorityImmediate.UseVisualStyleBackColor = true;
            // 
            // PriorityDelayed
            // 
            this.PriorityDelayed.AutoSize = true;
            this.PriorityDelayed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityDelayed.Location = new System.Drawing.Point(390, 21);
            this.PriorityDelayed.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.PriorityDelayed.Name = "PriorityDelayed";
            this.PriorityDelayed.Size = new System.Drawing.Size(92, 27);
            this.PriorityDelayed.TabIndex = 82;
            this.PriorityDelayed.TabStop = true;
            this.PriorityDelayed.Text = "Delayed";
            this.PriorityDelayed.UseVisualStyleBackColor = true;
            // 
            // PriorityHigh
            // 
            this.PriorityHigh.AutoSize = true;
            this.PriorityHigh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityHigh.Location = new System.Drawing.Point(9, 21);
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
            this.PriorityLow.Location = new System.Drawing.Point(187, 21);
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
            this.PriorityMedium.Location = new System.Drawing.Point(88, 21);
            this.PriorityMedium.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.PriorityMedium.Name = "PriorityMedium";
            this.PriorityMedium.Size = new System.Drawing.Size(94, 27);
            this.PriorityMedium.TabIndex = 80;
            this.PriorityMedium.TabStop = true;
            this.PriorityMedium.Text = "Medium";
            this.PriorityMedium.UseVisualStyleBackColor = true;
            // 
            // OrderReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 955);
            this.Controls.Add(this.PriorityGroup);
            this.Controls.Add(this.StatusGroup);
            this.Controls.Add(this.StatusLabel1);
            this.Controls.Add(this.PriorityReportButton);
            this.Controls.Add(this.StatusReportButton);
            this.Controls.Add(this.FieldSelectButton1);
            this.Controls.Add(this.FieldSelectButton);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "OrderReportView";
            this.Text = "OrderReportView";
            this.Load += new System.EventHandler(this.OrderReportView_Load);
            this.StatusGroup.ResumeLayout(false);
            this.StatusGroup.PerformLayout();
            this.PriorityGroup.ResumeLayout(false);
            this.PriorityGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FieldSelectButton;
        private System.Windows.Forms.Button FieldSelectButton1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button StatusReportButton;
        private System.Windows.Forms.Button PriorityReportButton;
        private System.Windows.Forms.Label StatusLabel1;
        private System.Windows.Forms.GroupBox StatusGroup;
        private System.Windows.Forms.RadioButton StatusDelayed;
        private System.Windows.Forms.RadioButton StatusReady;
        private System.Windows.Forms.RadioButton StatusPrinting;
        private System.Windows.Forms.RadioButton StatusDispatched;
        private System.Windows.Forms.RadioButton StatusConfirmed;
        private System.Windows.Forms.RadioButton StatusReceived;
        private System.Windows.Forms.GroupBox PriorityGroup;
        private System.Windows.Forms.RadioButton PriorityImmediate;
        private System.Windows.Forms.RadioButton PriorityDelayed;
        private System.Windows.Forms.RadioButton PriorityHigh;
        private System.Windows.Forms.RadioButton PriorityLow;
        private System.Windows.Forms.RadioButton PriorityMedium;
    }
}