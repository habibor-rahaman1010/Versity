using StationaryShopManagement.BO;
using StationaryShopManagement.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationaryShopManagement
{
    static class Program
    {
        public static Shop myShop;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<Product> seedProductList = new List<Product>
            {
                new Product {Name = "Ballpoint Pen (Stylist)", Code = "PEN-102", TotalQuantity = 10, ReorderLevel = 0},
                new Product {Name = "Gel Pen (0.5 mm)", Code = "PEN-103", TotalQuantity = 22 , ReorderLevel = 5},
                new Product {Name = "Gel Pen (0.7 mm)", Code = "PEN-104", TotalQuantity = 34 , ReorderLevel = 0},
                new Product {Name = "Pen Holder (Plastic)", Code = "HLD-101", TotalQuantity = 45, ReorderLevel = 0},
                new Product {Name = "Eraser", Code = "ERS-101", TotalQuantity = 54, ReorderLevel = 0},
                new Product {Name = "Pencil (2B)", Code = "PCL-101", TotalQuantity = 77, ReorderLevel = 0},
                new Product {Name = "Pencil (4B)", Code = "PCL-102", TotalQuantity = 32, ReorderLevel = 0},
                new Product {Name = "Pencil (8B)", Code = "PCL-103", TotalQuantity = 21, ReorderLevel = 5},
                new Product {Name = "Sharpener (Stylist)", Code = "SRP-102", TotalQuantity = 12, ReorderLevel = 0},
                new Product {Name = "Marker pen", Code = "MAR-101", TotalQuantity = 44, ReorderLevel = 0},
                new Product {Name = "Highlighter", Code = "HTR-101", TotalQuantity = 30, ReorderLevel = 5},
                new Product {Name = "Paper clip", Code = "CLP-101", TotalQuantity = 20, ReorderLevel = 10},
                new Product {Name = "Transparent file", Code = "TFL-101", TotalQuantity = 15, ReorderLevel = 20}
            }; 

            myShop = Shop.GetShop(seedProductList);
            Application.Run(new MainUI());
        }
    }
}
