using APIAssignmentOnEcomerce.Models;

namespace APIAssignmentOnEcomerce.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(string ProductName);
        List<Product> GetAllProduct();
        List<Product> GetProductByName(string ProductName);
        List<Product> GetProductByCategory(string Category);
    }
}
