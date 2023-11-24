using StationaryShopManagement.BO;
using System;
using System.Windows.Forms;

namespace StationaryShopManagement.UI
{
    public partial class SellUI : Form
    {
        public SellUI()
        {
            InitializeComponent();
            PopulateProductListComboBox();
        }

        private void PopulateProductListComboBox()
        {
            productListComboBox.Items.Clear();
            foreach (Product aProduct in Program.myShop.ProductList)
            {
                productListComboBox.Items.Add(aProduct);
            }
        }

private void productSellButton_Click(object sender, EventArgs e)
{
    Sale aSale = new Sale();
    aSale.Product = (Product)productListComboBox.SelectedItem;
    try
    { 
    aSale.TransactionQuantity = Convert.ToInt16(saleQuantityTextBox.Text);
    aSale.TotalAmount = Convert.ToDouble(totalAmountTextBox.Text);
    }
    catch (Exception exceptionObj)
    {
        MessageBox.Show("Please enter data in right format");
        return;
    }
            
    aSale.OperationDate = saleDateDateTimePicker.Value;
            
    if (aSale.Product != null)
    {
        string msg = Program.myShop.AddSale(aSale);
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
