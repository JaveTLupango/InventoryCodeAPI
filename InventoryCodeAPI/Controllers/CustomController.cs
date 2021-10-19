using InventoryCodeAPI.Classes;
using InventoryCodeAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomController : ControllerBase
    {
        private readonly CustomContext _context;

        public CustomController(CustomContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<string> CartList()
        {
            string ret = string.Empty;
                try
                {
                //IList<cart> cL = new List<cart>();
                //IList<Product> pL = new List<Product>();
                //IList<cartList> ca = new List<cartList>();
                //cL = await _context.carts.ToListAsync();
                //pL = await _context.products.ToListAsync();

                var aaas = (from a in await _context.carts.ToListAsync()
                            join b in await _context.products.ToListAsync()
                            on a.productid.ToString() equals b.id.ToString()
                            select new cartList
                            {
                                cartid = a.id,
                                productname = b.productName,
                                cartQTY = Int32.Parse(a.QTY),
                                productPrice = a.Price
                            }).ToList();

                //var jointable = cL.Join(
                //                        pL,
                //                        crt => crt.productid,
                //                        prd => prd.id,
                //                        (crt, prd) => new
                //                        { 
                //                            cartid = crt.id,
                //                            productID = prd.id
                //                        }

                          //   );
            }
                catch (Exception ex)
                {
                ret = ex.Message;
                }
            return ret;
        }

        [HttpPost]
        public async Task<string> CartCheckOut(int id = 1)
        {
            string ret = string.Empty;
            string orderid = DateTime.Now.ToString("yyyyMMddmmss");
            decimal totalCost = new decimal();
            try
            {
                IList<cart> cL = new List<cart>();
                Order orders = new Order();

                cL = (from a in await _context.carts.ToListAsync()
                     where a.userid.ToString() == id.ToString()
                     select a).ToList();

                for (int i = 0; i < cL.Count(); i++)
                {
                    var pd = _context.products.FirstOrDefault(item => item.id.ToString() == cL[i].productid.ToString());                             
                    OrderDetails orderDetails = new OrderDetails
                    {
                        Orderid = orderid,
                        ProductID = pd.id.ToString(),
                        QTY = Int32.Parse(cL[i].QTY),
                        TotalAmount = Int32.Parse(cL[i].QTY) * pd.ProductPrice
                    };
                    await CustomClass.addOrderDetailsAsync(orderDetails, _context);
                    totalCost += orderDetails.TotalAmount;
                    
                    await CustomClass.UpdateProductQTY(Int32.Parse(cL[i].productid), Int32.Parse(cL[i].QTY),_context);
                }

                Order order = new Order
                {
                    orderid = orderid,
                    customerid = id.ToString(),
                    totalCost = totalCost,
                    TotalProductPurchase = cL.Count()
                };

                await CustomClass.AddClientOrder(order, _context);

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return ret;
        }

        

    }
}
