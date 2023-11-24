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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Dashboard dashboardPage = new Dashboard();
                this.Hide();
                dashboardPage.ShowDialog();
            }
            else if (textBox1.Text == "client" && textBox2.Text == "client")
            {
                Dashboard dashboardPage = new Dashboard("client");
                this.Hide();
                dashboardPage.ShowDialog();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Plsease Enter Valid Cadintial!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello User! You Want To Exit From This Application?");
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //TextBox tx = new TextBox(); 
            textBox2.UseSystemPasswordChar = true;
            //this.Controls.Add(tx);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
