using Microservice_Authentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Microservice_Authentication.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        // GET: api/<Product>
        [HttpGet(Name = "GetUserProducts")]
        public IActionResult GetUserProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                Id = 1,
                Name = "Apple",
                Description = "Macbook Pro",
                Price = 1500,
                CategoryId = 1
            });
            products.Add(new Product
            {
                Id = 2,
                Name = "Hp",
                Description = "Elitebook",
                Price = 800,
                CategoryId = 2
            });
            products.Add(new Product
            {
                Id = 3,
                Name = "Dell",
                Description = "Inspiron",
                Price = 1000,
                CategoryId = 3
            });
            return new OkObjectResult(products);
        }

        [HttpGet(Name = "GetAdminProducts")]
        [Authorize(Roles = "Administrator")]
        public IActionResult GetAdminProducts()
        {
            List<AdminProducts> products = new List<AdminProducts>();
            products.Add(new AdminProducts
            {
                Id = 1,
                Name = "Apple",
                Price = 1500,
                SellerId = 1
            });
            products.Add(new AdminProducts
            {
                Id = 2,
                Name = "Hp",
                Price = 800,
                SellerId = 2
            });
            products.Add(new AdminProducts
            {
                Id = 3,
                Name = "Dell",
                Price = 1000,
                SellerId = 3
            });
            return new OkObjectResult(products);
        }

        // GET api/<Product>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Product>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Product>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Product>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
