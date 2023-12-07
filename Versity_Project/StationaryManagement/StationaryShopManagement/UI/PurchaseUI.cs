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

namespace StationaryShopManagement
{
    public partial class PurchaseUI : Form
    {
        public PurchaseUI()
        {
            InitializeComponent();
            PopulateProductListComboBox();
        }

        private void PopulateProductListComboBox()
        {
            productListComboBox.Items.Clear();
            foreach(Product aProduct in Program.myShop.ProductList)
            {
                productListComboBox.Items.Add(aProduct);
            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            Purchase aPurchase = new Purchase();
            aPurchase.Product = (Product)productListComboBox.SelectedItem;
            try
            {
                aPurchase.TransactionQuantity = Convert.ToInt16(purchaseQuantityTextBox.Text);
                aPurchase.TotalAmount = Convert.ToDouble(totalAmountTextBox.Text);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show("Please enter data in right format");
                return;
            }
            aPurchase.OperationDate = purchaseDateDateTimePicker.Value;
            aPurchase.VendorName = vendorNameTextBox.Text;
            if (aPurchase.Product != null)
            {
                string msg = Program.myShop.AddPurchase(aPurchase);
                PopulateProductListComboBox();
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Please select the product");
            }
        }
    }
}
