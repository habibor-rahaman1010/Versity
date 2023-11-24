namespace StationaryShopManagement.UI
{
    partial class DamageEntryUI
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.couseOfDamageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.damageQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.productListComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.damageDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveButton);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.couseOfDamageTextBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.damageQuantityTextBox);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.productListComboBox);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.damageDateDateTimePicker);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(533, 198);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Damage";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(408, 153);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.damageButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(97, 126);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 17);
            this.label18.TabIndex = 9;
            this.label18.Text = "Date";
            // 
            // couseOfDamageTextBox
            // 
            this.couseOfDamageTextBox.Location = new System.Drawing.Point(140, 90);
            this.couseOfDamageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.couseOfDamageTextBox.Name = "couseOfDamageTextBox";
            this.couseOfDamageTextBox.Size = new System.Drawing.Size(371, 22);
            this.couseOfDamageTextBox.TabIndex = 8;
            this.couseOfDamageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cause of Damage";
            // 
            // damageQuantityTextBox
            // 
            this.damageQuantityTextBox.Location = new System.Drawing.Point(140, 58);
            this.damageQuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.damageQuantityTextBox.Name = "damageQuantityTextBox";
            this.damageQuantityTextBox.Size = new System.Drawing.Size(371, 22);
            this.damageQuantityTextBox.TabIndex = 8;
            this.damageQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 62);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Damaged Quantity ";
            // 
            // productListComboBox
            // 
            this.productListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productListComboBox.FormattingEnabled = true;
            this.productListComboBox.Location = new System.Drawing.Point(140, 26);
            this.productListComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.productListComboBox.Name = "productListComboBox";
            this.productListComboBox.Size = new System.Drawing.Size(371, 24);
            this.productListComboBox.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Select Product";
            // 
            // damageDateDateTimePicker
            // 
            this.damageDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.damageDateDateTimePicker.Location = new System.Drawing.Point(143, 123);
            this.damageDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.damageDateDateTimePicker.Name = "damageDateDateTimePicker";
            this.damageDateDateTimePicker.Size = new System.Drawing.Size(368, 22);
            this.damageDateDateTimePicker.TabIndex = 0;
            // 
            // DamageEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 222);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DamageEntryUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damage Item";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.TextBox couseOfDamageTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox damageQuantityTextBox;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.ComboBox productListComboBox;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.DateTimePicker damageDateDateTimePicker;
}
}