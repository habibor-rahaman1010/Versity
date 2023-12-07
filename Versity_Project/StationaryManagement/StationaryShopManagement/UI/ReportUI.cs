using StationaryShopManagement.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationaryShopManagement.UI
{
    public partial class ReportUI : Form
    {
        public ReportUI()
        {
            InitializeComponent();
            totalTextBox.Text = "0";
        }
        string format = "";
        double totalAmount = 0;

        private void ShowSalesList(DateTime operationDate)
        {
            SetVisibilityOfTotalAmountTextBoxes(true);
            List<Sale> salesListOfADate = Program.myShop.GetSalesOfADate(operationDate);
            dailyReportListBox.Items.Clear();
            format = "{0,-30}\t{1,-20}\t{2,-20}\t{3,-20}";
            dailyReportListBox.Items.Add(string.Format(format, "Name", "Code", "Sale Qty", "Amount"));
            totalTextBox.Text = "0";
            totalAmount = 0;
            foreach (Sale aSale in salesListOfADate)
            {
                dailyReportListBox.Items.Add(string.Format(format, aSale.Product.Name, aSale.Product.Code, aSale.TransactionQuantity, aSale.TotalAmount));
                totalAmount += aSale.TotalAmount;
            }
            totalTextBox.Text = totalAmount.ToString();
        }

        private void ShowPurchaseList(DateTime operationDate)
        {
            SetVisibilityOfTotalAmountTextBoxes(true);
            List<Purchase> purchaseListOfADate = Program.myShop.GetPurchaseOfADate(operationDate);
            dailyReportListBox.Items.Clear();
            string format = "{0,-20}\t\t{1,-20}\t\t{2,-20}\t\t{3,-20}\t\t{4,-20}";
            dailyReportListBox.Items.Add(string.Format(format, "Name", "Code", "Purchase Qty", "Amount", "Vendor"));
            totalTextBox.Text = "0";
            totalAmount = 0;
            foreach (Purchase aPurchase in purchaseListOfADate)
            {
                dailyReportListBox.Items.Add(string.Format(format, aPurchase.Product.Name, aPurchase.Product.Code, aPurchase.TransactionQuantity, aPurchase.TotalAmount, aPurchase.VendorName));
                totalAmount += aPurchase.TotalAmount;
            }
            totalTextBox.Text = totalAmount.ToString();
        }

        private void ShowDamageList(DateTime operationDate)
        {
            SetVisibilityOfTotalAmountTextBoxes(false);
            List<Damage> damageListOfADate = Program.myShop.GetDamageOfADate(operationDate);
            dailyReportListBox.Items.Clear();
            format = "{0,-20}\t\t{1,-20}\t\t{2,-20}\t\t{3,-20}";
            dailyReportListBox.Items.Add(string.Format(format, "Name", "Code", "Damage Qty", "Cause of Damage"));
            foreach (Damage aDamage in damageListOfADate)
            {
                dailyReportListBox.Items.Add(string.Format(format, aDamage.Product.Name, aDamage.Product.Code, aDamage.TransactionQuantity, aDamage.CauseOfDamage));
            }
        }

        private void showSaleListButton_Click(object sender, EventArgs e)
        {
            DateTime soldDate = dailyOperationReportDateTimePicker.Value;
            ShowSalesList(soldDate);
        }

        private void showPurchaseListButton_Click(object sender, EventArgs e)
        {
            DateTime purchasedDate = dailyOperationReportDateTimePicker.Value;
            ShowPurchaseList(purchasedDate);
        }

        private void showDamageListButton_Click(object sender, EventArgs e)
        {
            DateTime damagedDate = dailyOperationReportDateTimePicker.Value;
            ShowDamageList(damagedDate);
        }

        private void SetVisibilityOfTotalAmountTextBoxes(bool isVisible)
        {
            totalAmountLabel.Visible = isVisible;
            totalTextBox.Visible = isVisible;
        }
    }
}
