using DashStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace DashStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Always call the base method first
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
       new Category { Id = 1, Name = "Smartphones", DisplayOrder = 1, CreatedDateTime = new DateTime(2026, 1, 1) },
       new Category { Id = 2, Name = "Laptops & PCs", DisplayOrder = 2, CreatedDateTime = new DateTime(2026, 1, 1) },
       new Category { Id = 3, Name = "Audio & Sound", DisplayOrder = 3, CreatedDateTime = new DateTime(2026, 1, 1) },
       new Category { Id = 4, Name = "Gaming", DisplayOrder = 4, CreatedDateTime = new DateTime(2026, 1, 1) }
   );

            // 2. Read the 50 products from the JSON file
            var jsonData = File.ReadAllText("products.json");
            var seedProducts = JsonSerializer.Deserialize<List<Product>>(jsonData);

            // 3. Convert them into real EF Core Products
            var productsToSeed = seedProducts.Select(p => new Product
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Price = p.Price,
                CategoryId = p.CategoryId,
                ImageUrl = p.ImageUrl,
                // Convert the Dictionary back to a string for the SQL Database
                SpecificationsJson = JsonSerializer.Serialize(p.Specifications)
            }).ToArray();

            // 4. Seed them all at once!
            modelBuilder.Entity<Product>().HasData(productsToSeed);
        }

        // --- Core E-Commerce Tables ---
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        // Optional: If you want to seed some default data when the database is created
    }  
}
