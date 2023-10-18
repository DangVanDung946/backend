using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public ProductsController(EcommerceContext context)
        {
            _context = context;
        }

        //thêm sản phẩm
        [HttpPost]
        public async Task<ActionResult<Product>> AddProduct(Product product)
        {
            if (_context == null)
            {
                return NotFound();
            }
            _context.ProductsList.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        //xem tất cả sản phẩm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            if (_context == null)
            {
                return NotFound();
            }
            return await _context.ProductsList.ToListAsync();
        }

        //xem sản phẩm theo id
        //GET : api/movies/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetMovies(Guid id)
        {
            if (_context == null)
            {
                return NotFound();
            }

            var product = await _context.ProductsList.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        //update sản phẩm
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> UpdateProuct(Guid id, Product product)
        {
            if (product.Id != id)
            {
                return BadRequest();
            }
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var updatedMovie = _context.ProductsList.FirstOrDefaultAsync(x => x.Id == id);
            return product;
        }

        //xoá
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var product = await _context.ProductsList.FindAsync(id);
            if (product == null) return NotFound();
            _context.ProductsList.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
