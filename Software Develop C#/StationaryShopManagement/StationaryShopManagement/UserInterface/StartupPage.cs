using StationaryShopManagement.UserInterface;
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
    public partial class StartupPage : Form
    {
        public StartupPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 5;
            if (panel1.Width >= 921)
            {
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }
    }
}
