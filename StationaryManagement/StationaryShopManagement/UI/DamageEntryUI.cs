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
    public partial class DamageEntryUI : Form
    {
        public DamageEntryUI()
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
        private void damageButton_Click(object sender, EventArgs e)
        {
            Damage aDamage = new Damage();
            aDamage.Product = (Product)productListComboBox.SelectedItem;
            aDamage.OperationDate = damageDateDateTimePicker.Value;
            try
            { 
                aDamage.TransactionQuantity = Convert.ToInt16(damageQuantityTextBox.Text);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show("Please enter quantity in right format");
                return;
            }

            aDamage.CauseOfDamage = couseOfDamageTextBox.Text;
            if (aDamage.Product != null)
            {
                string msg = Program.myShop.AddDamage(aDamage);
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
