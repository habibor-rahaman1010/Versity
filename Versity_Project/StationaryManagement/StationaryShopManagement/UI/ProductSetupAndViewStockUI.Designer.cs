namespace StationaryShopManagement.UI
{
    partial class ProductSetupAndViewStockUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productSaveButton = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.initialQtyTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.allProductRadioButton = new System.Windows.Forms.RadioButton();
            this.showLimitedRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productSaveButton);
            this.groupBox1.Controls.Add(this.productNameTextBox);
            this.groupBox1.Controls.Add(this.productCodeTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.reorderLevelTextBox);
            this.groupBox1.Controls.Add(this.initialQtyTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(225, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Enlisting";
            // 
            // productSaveButton
            // 
            this.productSaveButton.Location = new System.Drawing.Point(207, 123);
            this.productSaveButton.Name = "productSaveButton";
            this.productSaveButton.Size = new System.Drawing.Size(75, 23);
            this.productSaveButton.TabIndex = 4;
            this.productSaveButton.Text = "Save";
            this.productSaveButton.UseVisualStyleBackColor = true;
            this.productSaveButton.Click += new System.EventHandler(this.productSaveButton_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(110, 20);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.productNameTextBox.TabIndex = 0;
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(110, 46);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(172, 20);
            this.productCodeTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name";
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(110, 97);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(172, 20);
            this.reorderLevelTextBox.TabIndex = 3;
            this.reorderLevelTextBox.Text = "0";
            this.reorderLevelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // initialQtyTextBox
            // 
            this.initialQtyTextBox.Location = new System.Drawing.Point(110, 71);
            this.initialQtyTextBox.Name = "initialQtyTextBox";
            this.initialQtyTextBox.Size = new System.Drawing.Size(172, 20);
            this.initialQtyTextBox.TabIndex = 2;
            this.initialQtyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reorder Level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Initial Qty";
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.Location = new System.Drawing.Point(8, 239);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(782, 329);
            this.productListBox.TabIndex = 2;
            // 
            // allProductRadioButton
            // 
            this.allProductRadioButton.AutoSize = true;
            this.allProductRadioButton.Checked = true;
            this.allProductRadioButton.Location = new System.Drawing.Point(19, 188);
            this.allProductRadioButton.Name = "allProductRadioButton";
            this.allProductRadioButton.Size = new System.Drawing.Size(65, 17);
            this.allProductRadioButton.TabIndex = 4;
            this.allProductRadioButton.TabStop = true;
            this.allProductRadioButton.Text = "Show all";
            this.allProductRadioButton.UseVisualStyleBackColor = true;
            this.allProductRadioButton.CheckedChanged += new System.EventHandler(this.allProductRadioButton_CheckedChanged);
            // 
            // showLimitedRadioButton
            // 
            this.showLimitedRadioButton.AutoSize = true;
            this.showLimitedRadioButton.Location = new System.Drawing.Point(112, 190);
            this.showLimitedRadioButton.Name = "showLimitedRadioButton";
            this.showLimitedRadioButton.Size = new System.Drawing.Size(267, 17);
            this.showLimitedRadioButton.TabIndex = 4;
            this.showLimitedRadioButton.Text = "Products which reorder level exceeded the quantity";
            this.showLimitedRadioButton.UseVisualStyleBackColor = true;
            this.showLimitedRadioButton.CheckedChanged += new System.EventHandler(this.showLimitedRadioButton_CheckedChanged);
            // 
            // ProductSetupAndViewStockUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 571);
            this.Controls.Add(this.showLimitedRadioButton);
            this.Controls.Add(this.allProductRadioButton);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductSetupAndViewStockUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Stock & Product Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button productSaveButton;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox initialQtyTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton allProductRadioButton;
        private System.Windows.Forms.RadioButton showLimitedRadioButton;
    }
}