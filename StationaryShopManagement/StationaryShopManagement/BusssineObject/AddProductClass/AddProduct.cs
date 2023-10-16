using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement.BusssineObject.AddProductClass
{
    public class AddProduct : Product
    {
        public AddProduct(int id, string name, string color, double weight, int price, string description, int instock) { 
            this.Id = id;
            this.Name = name;
            this.Color = color;
            this.Weight = weight;
            this.Price = price;
            this.Description = description;
            this.Instock = instock;
        } 
    }
}
