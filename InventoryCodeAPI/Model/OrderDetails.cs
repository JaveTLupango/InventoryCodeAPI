using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryCodeAPI.Model
{
    public class OrderDetails
    {
        public int id { get; set; }
        public string Orderid { get; set; }
        public string ProductID { get; set; }
        public int QTY { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime TDT { get; set; }
        public DateTime UDT { get; set; }
    }
}
