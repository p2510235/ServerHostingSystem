using System;

namespace ServerHostingLibrary
{
    public class clsOrder
    {
        public bool Dispatched { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
        public string OrderDetails { get; set; }
        public int TotalPrice { get; set; }
    }
}