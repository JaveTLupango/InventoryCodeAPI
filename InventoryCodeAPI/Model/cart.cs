using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryCodeAPI.Model
{
    public class cart
    {
        public int id { get; set; }
        public string productid { get; set; }
        public string productName { get; set; }
        public string QTY { get; set; }
        public decimal Price { get; set; }
        public string userid { get; set; }
        public string status { get; set; }
        public DateTime TDT { get; set; }
        public DateTime UDT { get; set; }
    }

    public class cartList
    {
        public int cartid { get; set; }
        public string productname { get; set; }
        public int cartQTY { get; set; }
        public decimal productPrice { get; set; }
    }

}
