using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.Models;

namespace ProductMicroservice.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetAllProducts")]
        public ActionResult GetAllProducts()
        {
            List<Product> product = ProductDummyData();
            return Ok(product);
        }

        public List<Product> ProductDummyData()
        {
            IList<Product> product = new List<Product>()
            {
                new Product()
                {
                     Id = 1,
                     Name ="Product 1",
                     Price = 40000
                },
                new Product()
                {
                    Id = 2,
                    Name = "Product 2",
                    Price = 50000
                },
                new Product()
                {
                    Id = 3,
                    Name = "Product 3",
                    Price = 60000
                }
            };

            return product.ToList();
        }
    }
}