using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly IProductCategoryService _productCategoryService;

        public ProductCategoriesController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductCategories()
        {
            var productCategories = await _productCategoryService.GetAllProductCategoriesAsync();
            return Ok(productCategories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductCategoryById(int id)
        {
            var productCategory = await _productCategoryService.GetProductCategoryByIdAsync(id);
            return Ok(productCategory);
        }

        [HttpPost]
        public async Task<IActionResult> AddProductCategory(ProductCategory productCategory)
        {
            await _productCategoryService.AddProductCategoryAsync(productCategory);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductCategory(ProductCategory productCategory)
        {
            await _productCategoryService.UpdateProductCategoryAsync(productCategory);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductCategory(int id)
        {
            await _productCategoryService.DeleteProductCategoryAsync(id);
            return Ok();
        }
    }
}