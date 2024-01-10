using APIAssignmentOnEcomerce.Models;
using APIAssignmentOnEcomerce.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAssignmentOnEcomerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [HttpPost, Route("AddProduct")]
        public IActionResult Add(Product product)
        {
            try
            {

                productRepository.AddProduct(product);
                return StatusCode(200, product);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
            try
            {

                List<Product> products = productRepository.GetAllProduct();
                return StatusCode(200, products);

            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
    
        [HttpGet, Route("GetProductByName/{ProductName}")]

        public IActionResult GetProductByName(string ProductName)
        {
            try
            {
                return StatusCode(200, productRepository.GetProductByName(ProductName));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetProductByCategory/{Category}")]

        public IActionResult GetProductByCategory(string Category)
        {
            try
            {
                return StatusCode(200, productRepository.GetProductByCategory(Category));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpPut("UpdateProduct")]
        public IActionResult Update(Product product)
        {
            try
            {
                productRepository.UpdateProduct(product);
                return StatusCode(200, product);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpDelete("DeleteProduct/{ProductName}")]
        public IActionResult Delete(string ProductName)
        {
            try
            {
                productRepository.DeleteProduct(ProductName);
                return StatusCode(200, "Student was deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

    }
}
