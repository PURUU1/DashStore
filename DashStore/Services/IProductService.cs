using DashStore.Models;
using DashStore.ViewModels;

namespace DashStore.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Category> GetCategories();
        Product GetProduct(int id);
        List<Product> GetSuggetions(int CategoryId);
        IEnumerable<CategoryList>? GetProductsInCategory();
        //Product GetProductById(int id);
        //void AddProduct(Product product);
    }
}
