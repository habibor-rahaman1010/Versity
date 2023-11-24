namespace StationaryShopManagement.UI
{
    partial class ReportUI
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.showSaleListButton = new System.Windows.Forms.Button();
            this.showPurchaseListButton = new System.Windows.Forms.Button();
            this.showDamageListButton = new System.Windows.Forms.Button();
            this.dailyReportListBox = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dailyOperationReportDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.totalTextBox);
            this.groupBox6.Controls.Add(this.totalAmountLabel);
            this.groupBox6.Controls.Add(this.showSaleListButton);
            this.groupBox6.Controls.Add(this.showPurchaseListButton);
            this.groupBox6.Controls.Add(this.showDamageListButton);
            this.groupBox6.Controls.Add(this.dailyReportListBox);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.dailyOperationReportDateTimePicker);
            this.groupBox6.Location = new System.Drawing.Point(8, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(787, 387);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Daily Report";
            // 
            // showSaleListButton
            // 
            this.showSaleListButton.Location = new System.Drawing.Point(462, 53);
            this.showSaleListButton.Name = "showSaleListButton";
            this.showSaleListButton.Size = new System.Drawing.Size(99, 29);
            this.showSaleListButton.TabIndex = 9;
            this.showSaleListButton.Text = "Show Sale";
            this.showSaleListButton.UseVisualStyleBackColor = true;
            this.showSaleListButton.Click += new System.EventHandler(this.showSaleListButton_Click);
            // 
            // showPurchaseListButton
            // 
            this.showPurchaseListButton.Location = new System.Drawing.Point(567, 53);
            this.showPurchaseListButton.Name = "showPurchaseListButton";
            this.showPurchaseListButton.Size = new System.Drawing.Size(99, 29);
            this.showPurchaseListButton.TabIndex = 9;
            this.showPurchaseListButton.Text = "Show Purchase";
            this.showPurchaseListButton.UseVisualStyleBackColor = true;
            this.showPurchaseListButton.Click += new System.EventHandler(this.showPurchaseListButton_Click);
            // 
            // showDamageListButton
            // 
            this.showDamageListButton.Location = new System.Drawing.Point(672, 53);
            this.showDamageListButton.Name = "showDamageListButton";
            this.showDamageListButton.Size = new System.Drawing.Size(99, 29);
            this.showDamageListButton.TabIndex = 9;
            this.showDamageListButton.Text = "Show Damage";
            this.showDamageListButton.UseVisualStyleBackColor = true;
            this.showDamageListButton.Click += new System.EventHandler(this.showDamageListButton_Click);
            // 
            // dailyReportListBox
            // 
            this.dailyReportListBox.FormattingEnabled = true;
            this.dailyReportListBox.HorizontalScrollbar = true;
            this.dailyReportListBox.Location = new System.Drawing.Point(12, 96);
            this.dailyReportListBox.Name = "dailyReportListBox";
            this.dailyReportListBox.ScrollAlwaysVisible = true;
            this.dailyReportListBox.Size = new System.Drawing.Size(763, 251);
            this.dailyReportListBox.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(593, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Select Date";
            // 
            // dailyOperationReportDateTimePicker
            // 
            this.dailyOperationReportDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dailyOperationReportDateTimePicker.Location = new System.Drawing.Point(664, 23);
            this.dailyOperationReportDateTimePicker.Name = "dailyOperationReportDateTimePicker";
            this.dailyOperationReportDateTimePicker.Size = new System.Drawing.Size(107, 20);
            this.dailyOperationReportDateTimePicker.TabIndex = 0;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.Location = new System.Drawing.Point(15, 360);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(82, 13);
            this.totalAmountLabel.TabIndex = 10;
            this.totalAmountLabel.Text = "Total Amount";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(103, 357);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(128, 20);
            this.totalTextBox.TabIndex = 11;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 407);
            this.Controls.Add(this.groupBox6);
            this.Name = "ReportUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Report";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button showDamageListButton;
        private System.Windows.Forms.ListBox dailyReportListBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dailyOperationReportDateTimePicker;
        private System.Windows.Forms.Button showSaleListButton;
        private System.Windows.Forms.Button showPurchaseListButton;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}