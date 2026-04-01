using DashStore.Data;
using DashStore.Models;

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
