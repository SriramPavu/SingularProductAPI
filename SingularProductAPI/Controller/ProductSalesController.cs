using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SingularProductsAPI.Models;
using SingularProductsAPI.Services;

namespace SingularProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSalesController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public ProductSalesController(ApplicationDBContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        [HttpGet("details")]
        public ActionResult<IEnumerable<Product>> GetProductsDetails()
        {
            var products = _dbContext.Products.OrderByDescending(c => c.Id).ToList();
            return Ok(products);
        }

        [HttpGet("sales")]
        public ActionResult<IEnumerable<ProductSales>> GetProductssales()
        {
            var products = _dbContext.productSales.OrderByDescending(c => c.SaleId).ToList();
            return Ok(products);
        }
    }
}
