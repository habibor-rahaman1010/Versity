using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StationaryShopManagement.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void openPurchaseUIButton_Click(object sender, EventArgs e)
        {
            PurchaseUI purchaseUI = new PurchaseUI();
            purchaseUI.Show();
        }

        private void openSellUIButton_Click(object sender, EventArgs e)
        {
            SellUI sellUI = new SellUI();
            sellUI.Show();
        }

        private void openDamageEntryUIButton_Click(object sender, EventArgs e)
        {
            DamageEntryUI damageEntryUI = new DamageEntryUI();
            damageEntryUI.Show();
        }

        private void openViewReportUIButton_Click(object sender, EventArgs e)
        {
            ReportUI reportUI = new ReportUI();
            reportUI.Show();
        }

        private void openProductSetupUIButton_Click(object sender, EventArgs e)
        {
            ProductSetupAndViewStockUI productSetupUI = new ProductSetupAndViewStockUI();
            productSetupUI.Show();
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
    }
}
