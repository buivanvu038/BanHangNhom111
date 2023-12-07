using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using webBanHang.API.Models;

namespace webBanHang.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                // Trong thực tế, bạn sẽ truy vấn cơ sở dữ liệu để lấy sản phẩm theo ID
                var product = new Product
                {
                    ProductID = id,
                    ProductName = "Example Product",
                    Price = 19.99m,
                    StockQuantity = 50,
                    CategoryID = 1,
                    SupplierID = 1
                };

                if (product == null)
                {
                    return NotFound("Product not found");
                }

                return Ok(product);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving product: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        //[HttpPost]
        //public IActionResult AddProduct([FromBody] Product product)
        //{
        //    try
        //    {
        //        // Trong thực tế, bạn sẽ thêm sản phẩm vào cơ sở dữ liệu
        //        // và trả về thông tin chi tiết của sản phẩm đã được thêm
        //        var addedProduct = new Product
        //        {
        //            ProductID = 1,
        //            ProductName = product.ProductName,
        //            Price = product.Price,
        //            StockQuantity = product.StockQuantity,
        //            CategoryID = product.CategoryID,
        //            SupplierID = product.SupplierID
        //        };

        //        return Ok(addedProduct);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Error adding product: {ex.Message}");
        //        return StatusCode(500, "Internal server error");
        //    }
        //}
    }
}
