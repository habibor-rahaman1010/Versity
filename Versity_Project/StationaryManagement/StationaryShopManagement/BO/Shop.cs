using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement.BO
{
    public class Shop
    {
        public List<Product> ProductList { set; get; }
        public List<Purchase> PurchaseList { set; get; }
        public List<Sale> SalesList { set; get; }
        public List<Damage> DamageList { set; get; }
        private Shop()
        {
            ProductList = new List<Product>();
            PurchaseList = new List<Purchase>();
            SalesList = new List<Sale>();
            DamageList = new List<Damage>();
        }

        private static Shop aShop;
        public static Shop GetShop()
        {
            if (aShop == null)
            {
                aShop = new Shop();
            }
            return aShop;
        }
        public static Shop GetShop(List<Product> seedProducts)
        {
            Shop shop = GetShop();
            shop.ProductList = seedProducts;
            return aShop;
        }
        public string AddPurchase(Purchase aPurchase)
        {
            foreach (Product aProduct in ProductList)
            {
                if (aProduct.Code == aPurchase.Product.Code)
                {
                    aProduct.TotalQuantity += aPurchase.TransactionQuantity;
                }
            }
            PurchaseList.Add(aPurchase);
            return "Purchase has been updated.";
        }
        public string EnlistProduct(Product aProduct)
{
    foreach(Product product1 in ProductList)
    {
        if (product1.Code == aProduct.Code)
        {
            return "This product code is already enlisted.";
        }
        else if (product1.Name == aProduct.Name)
        {
            return "Product name is already enlisted.";
        }
    }
    ProductList.Add(aProduct);
    return "Product is enlisted.";
}
        public string AddSale(Sale aSale)
        {
            foreach (Product aProduct in ProductList)
            {
                if (aProduct.Code == aSale.Product.Code)
                {
                    if (aProduct.TotalQuantity >= aSale.TransactionQuantity)
                    {
                        aProduct.TotalQuantity -= aSale.TransactionQuantity;
                    }
                    else
                    {
                        return "Sorry, you have not enough quantity to sell";
                    }
                }
            }
            SalesList.Add(aSale);
            return "Sale has been updated.";
        }
        public string AddDamage(Damage aDamage)
        {
            foreach (Product aProduct in ProductList)
            {
                if (aProduct.Code == aDamage.Product.Code)
                {
                    if (aProduct.TotalQuantity >= aDamage.TransactionQuantity)
                    {
                        aProduct.TotalQuantity -= aDamage.TransactionQuantity;
                    }
                    else
                    {
                        return "Sorry, you have not enough quantity to record damage info of this product";
                    }
                }
            }
            DamageList.Add(aDamage);
            return "Damage information has been recorded.";
        }
        public List<Sale> GetSalesOfADate(DateTime saleDate)
        {
            List<Sale> salesListOfADate = new List<Sale>();
            foreach (Sale aSale in SalesList)
            {
                if (aSale.OperationDate.Date == saleDate.Date)
                {
                    salesListOfADate.Add(aSale);
                }
            }
            return salesListOfADate;
        }
        public List<Purchase> GetPurchaseOfADate(DateTime purchaseDate)
        {
            List<Purchase> purchaseListOfADate = new List<Purchase>();
            foreach (Purchase aPurchase in PurchaseList)
            {
                if (aPurchase.OperationDate.Date == purchaseDate.Date)
                {
                    purchaseListOfADate.Add(aPurchase);
                }
            }
            return purchaseListOfADate;
        }
        public List<Damage> GetDamageOfADate(DateTime damageDate)
        {
            List<Damage> damageListOfADate = new List<Damage>();
            foreach (Damage aDamage in DamageList)
            {
                if (aDamage.OperationDate.Date == damageDate.Date)
                {
                    damageListOfADate.Add(aDamage);
                }
            }
            return damageListOfADate;
        }
    }
}
