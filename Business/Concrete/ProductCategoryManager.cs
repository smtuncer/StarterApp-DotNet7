using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductCategoryManager : IProductCategoryService
    {
        private readonly IRepository<ProductCategory> _productCategoryRepository;

        public ProductCategoryManager(IRepository<ProductCategory> productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }
        public async Task<IEnumerable<ProductCategory>> GetAllProductCategoriesAsync()
        {
            return await _productCategoryRepository.GetAllAsync();
        }

        public async Task<ProductCategory> GetProductCategoryByIdAsync(int id)
        {
            return await _productCategoryRepository.GetByIdAsync(id);
        }

        public async Task AddProductCategoryAsync(ProductCategory productCategory)
        {
            await _productCategoryRepository.AddAsync(productCategory);

        }

        public async Task UpdateProductCategoryAsync(ProductCategory productCategory)
        {
            _productCategoryRepository.UpdateAsync(productCategory);
        }

        public async Task DeleteProductCategoryAsync(int id)
        {
            _productCategoryRepository.DeleteAsync(id);
        }
    }
}
