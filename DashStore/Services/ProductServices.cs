using DashStore.Data;
using DashStore.Models;
using DashStore.ViewModels;
using System.Collections.Generic;

namespace DashStore.Services
{
    public class ProductServices : IProductService
    {
        private readonly ApplicationDbContext _db;

        // 2. Inject it via the Constructor!
        public ProductServices(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = _db.Products.ToList();
            
            foreach(var product in products)
            {
                //product.Category = _db.Categories.FirstOrDefault(x => x.Id.Equals(product.CategoryId)).Name.Cast<Category>();
                // This finds the full Category object and stores it in the product
                product.Category = _db.Categories.FirstOrDefault(x => x.Id == product.CategoryId);
            }
         

            return products;

        }
        public IEnumerable<CategoryList> GetProductsInCategory()
        {
         var categories = _db.Categories.ToList();
            List<CategoryList> ProductsWithCat = new List<CategoryList>();

            var products = this.GetAllProducts();
            foreach (var category in categories) {
                CategoryList item = new CategoryList();
                item.Name = category.Name;
                //item.ProductsByCategory = products.Where(x=>x.Category.Equals(category.Name)).ToList();
                item.ProductsByCategory = this.GetSuggetions(category.Id);
                ProductsWithCat.Add(item);
            }

            return ProductsWithCat;

        }
        public List<Product> GetSuggetions(int categoryId)
        {
            var products = _db.Products.ToList();
            
            foreach(var product in products)
            {
                //product.Category = _db.Categories.FirstOrDefault(x => x.Id.Equals(product.CategoryId)).Name.Cast<Category>();
                // This finds the full Category object and stores it in the product
                product.Category = _db.Categories.FirstOrDefault(x => x.Id == product.CategoryId);
            }

            var suggestions = products.Where(x => x.CategoryId.Equals(categoryId)).ToList();

            return suggestions;

        }
        public IEnumerable<Category> GetCategories()
        {
            var categories = _db.Categories.ToList();
            
            
           

            return categories;

        }
        public Product GetProduct(int id)
        {


           var product = _db.Products.FirstOrDefault(x => x.Id.Equals(id));
           if(product is not null)
            {
            product.Category = _db.Categories.FirstOrDefault(x => x.Id == product.CategoryId);
                return product ;
            }

            var EmptyProduct = new Product();
            return  EmptyProduct;

        }

       
    }
}
