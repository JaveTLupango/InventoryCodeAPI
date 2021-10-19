using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryCodeAPI.Model
{
    public class Order
    {
        public int id { get; set; }
        public string orderid { get; set; }
        public string customerid { get; set; }
        public decimal totalCost { get; set; }
        public int TotalProductPurchase { get; set; }
        public DateTime UDT { get; set; }
        public DateTime TDT { get; set; }
        public string status { get; set; }
    }
}
