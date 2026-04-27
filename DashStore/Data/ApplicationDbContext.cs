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

   //         modelBuilder.Entity<Category>().HasData(
   //    new Category { Id = 1, Name = "Smartphones", DisplayOrder = 1, CreatedDateTime = new DateTime(2026, 1, 1) },
   //    new Category { Id = 2, Name = "Laptops & PCs", DisplayOrder = 2, CreatedDateTime = new DateTime(2026, 1, 1) },
   //    new Category { Id = 3, Name = "Audio & Sound", DisplayOrder = 3, CreatedDateTime = new DateTime(2026, 1, 1) },
   //    new Category { Id = 4, Name = "Gaming", DisplayOrder = 4, CreatedDateTime = new DateTime(2026, 1, 1) }
   //);




            DateTime seedDate = new DateTime(2024, 1, 1);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Smartphones", DisplayOrder = 1, CreatedDateTime = seedDate },
                new Category { Id = 2, Name = "Laptops & PCs", DisplayOrder = 2, CreatedDateTime = seedDate },
                new Category { Id = 3, Name = "Mobile Accesory  ", DisplayOrder = 3, CreatedDateTime = seedDate },
                new Category { Id = 4, Name = "Audio & Sound  ", DisplayOrder = 3, CreatedDateTime = seedDate },
                //new Category { Id = 4, Name = "Gaming", DisplayOrder = 4, CreatedDateTime = seedDate },
                //new Category { Id = 5, Name = "Monitors", DisplayOrder = 5, CreatedDateTime = seedDate },
                new Category { Id = 5, Name = "Storage", DisplayOrder = 5, CreatedDateTime = seedDate }, // Added for SSDs
    new Category { Id = 6, Name = "Wearables", DisplayOrder = 6, CreatedDateTime = seedDate },
    new Category { Id = 7, Name = "Monitors", DisplayOrder = 7, CreatedDateTime = seedDate }  // Added for Screens
                //new Category { Id = 6, Name = "Wearables", DisplayOrder = 6, CreatedDateTime = seedDate }
            );

            // 2. Read the 50 products from the JSON file
            var jsonData = File.ReadAllText("product2.json");
            var seedProducts = JsonSerializer.Deserialize<List<Product>>(jsonData);

            // 3. Convert them into real EF Core Products
            var productsToSeed = seedProducts.Select(p => new Product
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Price = p.Price,
                CategoryId = p.CategoryId,
                ImageUrl = p.ImageUrl, // This is your main thumbnail

                // Convert the Dictionary back to a string for the SQL Database
                SpecificationsJson = JsonSerializer.Serialize(p.Specifications),

                // FIX: Convert the List<string> back to a string for the SQL Database
                ImagesJson = JsonSerializer.Serialize(p.Images)

            }).ToArray();

            // 4. Seed them all at once!
            modelBuilder.Entity<Product>().HasData(productsToSeed);
        }

        // --- Core E-Commerce Tables ---
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<WishlistItem> WishlistItems { get; set; }


        // Optional: If you want to seed some default data when the database is created
    }  
}
