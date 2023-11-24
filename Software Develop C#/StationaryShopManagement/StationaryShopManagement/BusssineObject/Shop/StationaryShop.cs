using StationaryShopManagement.BusssineObject.AddProductClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement.BusssineObject.Shop
{
    public class StationaryShop
    {
        public List<Product> AllProducts { get; set; }

        public StationaryShop() { 
            this.AllProducts = new List<Product>();
        }
        public void AddProductTOList(Product product)
        {

            this.AllProducts.Add(product);
        }

        public List<Product> GetALLProducts()
        {
            return this.AllProducts;
        }
    }
}
