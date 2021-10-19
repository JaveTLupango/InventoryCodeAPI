using InventoryCodeAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryCodeAPI.Classes
{
    public class CustomClass
    {

        public static async Task addOrderDetailsAsync(OrderDetails orderDetails, CustomContext _context)
        {
            try
            {
                _context.orderDetails.Add(orderDetails);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task UpdateProductQTY(int productID, int QTY, CustomContext _context)
        {
            try
            {
                var productDetails = _context.products.FirstOrDefault(item => item.id == productID);
                productDetails.stocks = productDetails.stocks - QTY;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task AddClientOrder(Order order, CustomContext _context)
        {
            try
            {
                _context.orders.Add(order);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
