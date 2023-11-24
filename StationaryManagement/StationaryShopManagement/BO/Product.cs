using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement.BO
{
    public class Product
    {
        public string Name { set; get; }
        public string Code { set; get; }
        public int TotalQuantity { set; get; }
        public int ReorderLevel { set; get; }
        public override string ToString()
        {
            return Name + " || Code: " + Code + " Qty: " + TotalQuantity;
        }

        public Product()
        {
 
        }
    }
}
