using Laboratorio13.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsCustomController : ControllerBase
    {
        private readonly ProductContext _context;

        public ProductsCustomController(ProductContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            return await _context.Products.ToListAsync();
        }
    }
}
