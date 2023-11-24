namespace StationaryShopManagement.UI
{
    partial class SellUI
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saleDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productSellButton = new System.Windows.Forms.Button();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.saleQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saleDateDateTimePicker);
            this.groupBox3.Controls.Add(this.productSellButton);
            this.groupBox3.Controls.Add(this.totalAmountTextBox);
            this.groupBox3.Controls.Add(this.saleQuantityTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.productListComboBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(16, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(509, 195);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Sale to Customer";
            // 
            // saleDateDateTimePicker
            // 
            this.saleDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.saleDateDateTimePicker.Location = new System.Drawing.Point(135, 90);
            this.saleDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saleDateDateTimePicker.Name = "saleDateDateTimePicker";
            this.saleDateDateTimePicker.Size = new System.Drawing.Size(352, 22);
            this.saleDateDateTimePicker.TabIndex = 0;
            // 
            // productSellButton
            // 
            this.productSellButton.Location = new System.Drawing.Point(387, 152);
            this.productSellButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productSellButton.Name = "productSellButton";
            this.productSellButton.Size = new System.Drawing.Size(100, 28);
            this.productSellButton.TabIndex = 5;
            this.productSellButton.Text = "Sell";
            this.productSellButton.UseVisualStyleBackColor = true;
            this.productSellButton.Click += new System.EventHandler(this.productSellButton_Click);
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(135, 119);
            this.totalAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(352, 22);
            this.totalAmountTextBox.TabIndex = 4;
            this.totalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // saleQuantityTextBox
            // 
            this.saleQuantityTextBox.Location = new System.Drawing.Point(135, 59);
            this.saleQuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saleQuantityTextBox.Name = "saleQuantityTextBox";
            this.saleQuantityTextBox.Size = new System.Drawing.Size(352, 22);
            this.saleQuantityTextBox.TabIndex = 4;
            this.saleQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Bill Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sale Quantity ";
            // 
            // productListComboBox
            // 
            this.productListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productListComboBox.FormattingEnabled = true;
            this.productListComboBox.Location = new System.Drawing.Point(135, 26);
            this.productListComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productListComboBox.Name = "productListComboBox";
            this.productListComboBox.Size = new System.Drawing.Size(352, 24);
            this.productListComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Product";
            // 
            // SellUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 223);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SellUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker saleDateDateTimePicker;
        private System.Windows.Forms.Button productSellButton;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.TextBox saleQuantityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox productListComboBox;
        private System.Windows.Forms.Label label1;
    }
}