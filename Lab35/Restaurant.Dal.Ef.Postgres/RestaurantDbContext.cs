using Restaurant.Entities;
using System;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Dal.Ef.Postgres
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
            //Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host = 127.0.0.1; port = 5432; database = Restaurant; user id = Yarik; password = 1");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RestaurantEntity>().HasKey(c => new { c.Id });
            builder.Entity<Dish>().HasKey(c => new { c.Id });
            builder.Entity<Ingredient>().HasKey(c => new { c.Id }); ;
            builder.Entity<Order>().HasKey(c => new { c.Id });

            /*builder.Entity<OrderDish>().HasKey(c => new { c.DishId, c.OrderId });
            builder.Entity<OrderDish>()
                .HasOne<Order>(sc => sc.Order)
                .WithMany(s => s.OrderDishes)
                .HasForeignKey(sc => sc.OrderId);
            builder.Entity<OrderDish>()
                .HasOne<Dish>(sc => sc.Dish)
                .WithMany(s => s.OrderDishes)
                .HasForeignKey(sc => sc.DishId);

            builder.Entity<IngredientDish>().HasKey(c => new { c.DishId, c.IngredientId });
            builder.Entity<IngredientDish>()
                .HasOne<Ingredient>(sc => sc.Ingredient)
                .WithMany(s => s.IngredientDishes)
                .HasForeignKey(sc => sc.IngredientId);
            builder.Entity<IngredientDish>()
                .HasOne<Dish>(sc => sc.Dish)
                .WithMany(s => s.IngredientDishes)
                .HasForeignKey(sc => sc.DishId);*/
            builder.Entity<OrderDish>().HasKey(sc => new { sc.DishId, sc.OrderId });
            builder.Entity<IngredientDish>().HasKey(sc => new { sc.IngredientId, sc.DishId });
        }
        public DbSet<RestaurantEntity> Restaurant { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDish> OrderDishes { get; set; }
        public DbSet<IngredientDish> IngredientDishes { get; set; }
    }
}
