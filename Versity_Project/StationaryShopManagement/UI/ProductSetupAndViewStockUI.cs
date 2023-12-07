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
    public partial class ProductSetupAndViewStockUI : Form
    {
        public ProductSetupAndViewStockUI()
        {
            InitializeComponent();
            UpdateProductListBox();
        }

        private void productSaveButton_Click(object sender, EventArgs e)
        {
            if (productNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Name is missing");
                return;
            }
            if (productCodeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Code is missing");
                return;
            }

            Product aProduct = new Product();
            allProductRadioButton.Checked = true;
            aProduct.Name = productNameTextBox.Text;
            aProduct.Code = productCodeTextBox.Text;
            try
            { 
                aProduct.TotalQuantity = Convert.ToInt32(initialQtyTextBox.Text);
                aProduct.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show("Please enter data in right format");
                return;
            }

            if (aProduct != null)
            {
                string msg = Program.myShop.EnlistProduct(aProduct);
                UpdateProductListBox();
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Please select the product");
            }
        }

        public void UpdateProductListBox()
        {
            productListBox.Items.Clear();
            productListBox.BackColor = Color.WhiteSmoke;
            string format = "{0,-35}\t\t{1,-35}\t\t{2,-35}\t\t{3,-35}";
            productListBox.Items.Add(string.Format(format, "Name", "Code", "Quantity", "Reorder Level"));
            
            foreach (Product aProduct in Program.myShop.ProductList)
            {
                productListBox.Items.Add(string.Format(format, aProduct.Name, aProduct.Code, aProduct.TotalQuantity, aProduct.ReorderLevel));
            }
        }

        private void showLimitedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ShowShortageProducts();
        }

        private void ShowShortageProducts()
        {
            productListBox.Items.Clear();
            productListBox.BackColor = Color.LightGoldenrodYellow;
            string format = "{0,-20}\t\t{1,-20}\t\t{2,-20}\t\t{3,-20}";
            productListBox.Items.Add(string.Format(format, "Name", "Code", "Quantity", "Reorder Level"));

            foreach (Product aProduct in Program.myShop.ProductList)
            {
                if (aProduct.TotalQuantity < aProduct.ReorderLevel)
                {
                    productListBox.Items.Add(string.Format(format, aProduct.Name, aProduct.Code, aProduct.TotalQuantity, aProduct.ReorderLevel));
                }
            }
        }

        private void allProductRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProductListBox();
        }
    }
}
