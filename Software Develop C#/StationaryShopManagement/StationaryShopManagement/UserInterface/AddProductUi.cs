using StationaryShopManagement.BusssineObject.AddProductClass;
using StationaryShopManagement.BusssineObject.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationaryShopManagement.UserInterface
{
    public partial class AddProductUi : Form
    {
        public AddProductUi()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13);
            dataGridView1.ScrollBars = ScrollBars.Both;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(
                int.Parse(textBox1.Text),
                textBox2.Text,
                textBox3.Text,
                double.Parse(textBox4.Text),
                int.Parse(textBox5.Text),
                textBox6.Text,
                int.Parse(textBox7.Text)
                );
          
            StationaryShop stationaryShop = new StationaryShop();
            stationaryShop.AddProductTOList(addProduct);

            List<Product>products = stationaryShop.GetALLProducts();
            dataGridView1.ColumnCount = 7; 
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Color";
            dataGridView1.Columns[3].Name = "Weight";
            dataGridView1.Columns[4].Name = "Price";
            dataGridView1.Columns[5].Name = "Description";
            dataGridView1.Columns[6].Name = "InStock";

            foreach (Product product in products)
            {
                dataGridView1.Rows.Add(product.Id, product.Name, product.Color, product.Weight, product.Price, product.Description, product.Instock);
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            label11.Text = products.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboardPage = new Dashboard();
            this.Hide();
            dashboardPage.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }
    }
}
