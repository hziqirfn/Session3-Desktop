using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Session3_API.models;

namespace Session3_API.Controllers
{
    [ApiController]
    [Route("api/")]
    public class Session3Controller : ControllerBase
    {   
        BelleCroissantLyonnaisDatabaseContext db = new BelleCroissantLyonnaisDatabaseContext();

        //Product
        [HttpGet("products")]
        public async Task<object> products()
        {
            var product = await db.Products.ToListAsync();
            return product;
        }

        [HttpGet("products/{id}")]
        public async Task<IActionResult> productsId(int id)
        {
            var ProdId = await db.Products.FirstOrDefaultAsync(y => y.ProductId == id);

            if (ProdId == null)
            {
                return NotFound("Product Id not exist");
            }
            return Ok(ProdId);
        }

        [HttpPost("products")]
        public async Task<IActionResult> newProducts(Product additem)
        {
            bool item = await db.Products.AnyAsync(x => x.ProductName == additem.ProductName);

            if (!item)
            {
                db.Products.Add(additem);
                await db.SaveChangesAsync();
                return Ok(additem);
            }
            return BadRequest("Product already exist");
        }

        [HttpPut("products/{id}")]
        public async Task<IActionResult> editProducts(Product edit, int id)
        {
            var item = await db.Products.FindAsync(id);

            if (edit.ProductId != id)
            {
                return BadRequest("Product Id not same");
            }

            if (item != null)
            {
                db.Entry(item).CurrentValues.SetValues(edit);
                await db.SaveChangesAsync();
                return Ok(item);
            }
            return NotFound("Product Id not exist");
        }

        [HttpDelete("products/{id}")]
        public async Task<IActionResult> deleteProduct(int id)
        {
            var delete = await db.Products.FindAsync(id);

            if (delete != null)
            {
                var find = await db.OrderItems.Where(x => x.ProductId == id).ToListAsync();
                db.OrderItems.RemoveRange(find);
                db.Products.Remove(delete);
                await db.SaveChangesAsync();
                return Ok("Id:" + id + " Delete Successfully");
            }
            return NotFound("Product Id not exist");
        }

        //Customer
        [HttpGet("customers")]
        public async Task<object> customer()
        {
            var cus = await db.Customers.ToListAsync();
            return cus;
        }

        [HttpGet("customers/{id}")]
        public async Task<IActionResult> customerId(int id)
        {
            var cus = await db.Customers.FirstOrDefaultAsync(x => x.CustomerId == id);

            if (cus == null)
            {
                return NotFound("Customer Id not exist");
            }
            return Ok(cus);
        }

        [HttpPost("customers")]
        public async Task<IActionResult> newCustomer(Customer cus)
        {
            var newCus = await db.Customers.FirstOrDefaultAsync(x => x.Email == cus.Email || x.PhoneNumber == cus.PhoneNumber);

            if (newCus == null)
            {
                db.Customers.Add(cus);
                await db.SaveChangesAsync();
                return Ok(cus);
            }
            return BadRequest("Email or Phone Number already exist");
        }

        [HttpPut("customers/{id}")]
        public async Task<IActionResult> editCus(Customer cus, int id)
        {
            var edit = await db.Customers.FindAsync(id);

            if (id != cus.CustomerId)
            {
                return BadRequest("Customer Id not same");
            }

            if (edit != null)
            {
                db.Entry(edit).CurrentValues.SetValues(cus);
                await db.SaveChangesAsync();
                return Ok("Update Successfully");
            }
            return NotFound("Customer Id not exist");
        }

        //Order
        [HttpGet("orders")]
        public async Task<object> order()
        {
            var ord = await db.Orders.ToListAsync();
            return ord;
        }

        [HttpGet("ordersCus")]
        public async Task<object> orderCus()
        {
            var ord = await db.Orders
                .Include(x => x.Customer)
                .Select(x => new
                {
                    x.TransactionId,
                    customerName = x.Customer.displayName,
                    x.OrderDate,
                    x.TotalAmount,
                    x.Status
                }).ToListAsync();

            return ord;
        }

        [HttpGet("orders/{id}")]
        public async Task<IActionResult> orderId(int id)
        {
            var ord = await db.Orders.Where(x => x.CustomerId == id).ToListAsync();

            if (ord.Count != 0)
            {
                return Ok(ord);
            }
            return NotFound("Order not found");
        }

        [HttpPost("orders")]
        public async Task<IActionResult> newOrder(Order ord)
        {
            bool id = await db.Customers.AnyAsync(x => x.CustomerId == ord.CustomerId);

            if (id)
            {
                db.Orders.Add(ord);
                await db.SaveChangesAsync();
                return Ok(ord);
            }
            return NotFound("Customer Id not exist");
        }

        [HttpPut("orders/{id}/pend")]
        public async Task<IActionResult> pendingOrder(int id)
        {
            var edit = await db.Orders.FindAsync(id);

            if (id != edit.TransactionId)
            {
                return BadRequest("Order Id not same");
            }

            if (edit != null)
            {
                edit.Status = "Pending";
                await db.SaveChangesAsync();
                return Ok(edit);
            }
            return NotFound("Order not found");
        }

        [HttpPut("orders/{id}/process")]
        public async Task<IActionResult> processingOrder(int id)
        {
            var edit = await db.Orders.FindAsync(id);

            if (id != edit.TransactionId)
            {
                return BadRequest("Order Id not same");
            }

            if (edit != null)
            {
                edit.Status = "Processing";
                await db.SaveChangesAsync();
                return Ok(edit);
            }
            return NotFound("Order not found");
        }

        [HttpPut("orders/{id}/complete")]
        public async Task<IActionResult> completeOrder(int id)
        {
            var edit = await db.Orders.FindAsync(id);

            if (id != edit.TransactionId)
            {
                return BadRequest("Order Id not same");
            }

            if (edit != null)
            {
                edit.Status = "Completed";
                await db.SaveChangesAsync();
                return Ok(edit);
            }
            return NotFound("Order not found");
        }

        [HttpPut("orders/{id}/cancel")]
        public async Task<IActionResult> cancelOrder(int id)
        {
            var edit = await db.Orders.FindAsync(id);

            if (id != edit.TransactionId)
            {
                return BadRequest("Order Id not same");
            }

            if (edit != null)
            {
                edit.Status = "Cancelled";
                await db.SaveChangesAsync();
                return Ok(edit);
            }
            return NotFound("Order not found");
        }

        //orderItem
        [HttpGet("orderItem/{id}")]
        public async Task<IActionResult> orderItemId(int id)
        {
            var ord = await db.OrderItems.Where(x => x.TransactionId == id).ToListAsync();

            if (ord.Count != 0)
            {
                return Ok(ord);
            }
            return NotFound("Order not found");
        }
    }
}
