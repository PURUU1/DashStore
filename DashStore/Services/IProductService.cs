using DashStore.Models;

namespace DashStore.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Category> GetCategories();
        Product GetProduct(int id);
        //Product GetProductById(int id);
        //void AddProduct(Product product);
    }
}
