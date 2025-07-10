using ESHOPONLINE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ESHOPONLINE.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets (Veritabanı tabloları)
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // This is required for Identity!

            // Primary Keys
            modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);
            modelBuilder.Entity<Order>().HasKey(o => o.OrderId);
            modelBuilder.Entity<OrderItem>().HasKey(oi => oi.OrderItemId);
            modelBuilder.Entity<ProductIngredient>()
                .HasKey(pi => new { pi.ProductId, pi.IngredientId });

            // Relations
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.UserId);

            // Seed data
            modelBuilder.Entity<Category>().HasData(
                 new Category { CategoryId = 1, CategoryName = "Appetizer" },
               new Category { CategoryId = 2, CategoryName = "Entree" },
               new Category { CategoryId = 3, CategoryName = "Side Dish" },
               new Category { CategoryId = 4, CategoryName = "Dessert" },
               new Category { CategoryId = 5, CategoryName = "Beverage" }
           );

            modelBuilder.Entity<Ingredient>().HasData(
              //add mexican restaurant ingredients here
              new Ingredient { IngredientId = 1, Name = "Beef" },
              new Ingredient { IngredientId = 2, Name = "Chicken" },
              new Ingredient { IngredientId = 3, Name = "Fish" },
              new Ingredient { IngredientId = 4, Name = "Tortilla" },
              new Ingredient { IngredientId = 5, Name = "Lettuce" },
              new Ingredient { IngredientId = 6, Name = "Tomato" }
          );

            modelBuilder.Entity<Product>().HasData(

                //Add mexican restaurant food entries here
                new Product
                {
                    ProductId = 1,
                    ProductName = "Beef Taco",
                    Description = "A delicious beef taco",
                    Price = 2.50m,
                    Stock = 100,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Chicken Taco",
                    Description = "A delicious chicken taco",
                    Price = 1.99m,
                    Stock = 101,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Fish Taco",
                    Description = "A delicious fish taco",
                    Price = 3.99m,
                    Stock = 90,
                    CategoryId = 2
                }
                );

            modelBuilder.Entity<ProductIngredient>().HasData(
                new ProductIngredient { ProductId = 1, IngredientId = 1 },
                new ProductIngredient { ProductId = 1, IngredientId = 4 },
                new ProductIngredient { ProductId = 1, IngredientId = 5 },
                new ProductIngredient { ProductId = 1, IngredientId = 6 },
                new ProductIngredient { ProductId = 2, IngredientId = 2 },
                new ProductIngredient { ProductId = 2, IngredientId = 4 },
                new ProductIngredient { ProductId = 2, IngredientId = 5 },
                new ProductIngredient { ProductId = 2, IngredientId = 6 },
                new ProductIngredient { ProductId = 3, IngredientId = 3 },
                new ProductIngredient { ProductId = 3, IngredientId = 4 },
                new ProductIngredient { ProductId = 3, IngredientId = 5 },
                new ProductIngredient { ProductId = 3, IngredientId = 6 }
            );
        }
    }
}

