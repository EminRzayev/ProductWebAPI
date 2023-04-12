using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRODUCT.Data;
using PRODUCT.Entities;

namespace PRODUCT.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _context;

        public ProductController(ProductDbContext context)
        {
            _context = context;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_context.Set<Product>());
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_context.Set<Product>().SingleOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Set<Product>().Add(product);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Update(int id, string name, string price)
        {
            var product = _context.Set<Product>().SingleOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            product.Name = name;
            product.Price = price;

            _context.Set<Product>().Update(product);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = _context.Set<Product>().SingleOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Set<Product>().Remove(product);
            _context.SaveChanges();

            return Ok();
        }

    }
}
