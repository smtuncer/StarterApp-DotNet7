using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<ProductCategory>> GetAllProductCategoriesAsync();
        Task<ProductCategory> GetProductCategoryByIdAsync(int id);
        Task AddProductCategoryAsync(ProductCategory productCategory);
        Task UpdateProductCategoryAsync(ProductCategory productCategory);
        Task DeleteProductCategoryAsync(int id);
    }
}
