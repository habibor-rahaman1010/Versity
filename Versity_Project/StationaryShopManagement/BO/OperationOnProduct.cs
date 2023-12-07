using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement.BO
{
    public class OperationOnProduct
    {
        public Product Product { set; get; }
        public DateTime OperationDate { set; get; }
        public int TransactionQuantity { set; get; }
    }
}
