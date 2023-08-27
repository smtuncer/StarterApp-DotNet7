using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
