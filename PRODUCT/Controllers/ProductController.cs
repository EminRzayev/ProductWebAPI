using Microsoft.AspNetCore.Mvc;

namespace PRODUCT.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }

    }
}
