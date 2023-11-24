using StationaryShopManagement.BusssineObject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement.BusssineObject.AddProductClass
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Instock { get; set; }
    }
}
