namespace StationaryShopManagement.BO
{
    public class Purchase : OperationOnProduct
    {
        public string VendorName { set; get; }
        public double TotalAmount { set; get; }
    }
}
