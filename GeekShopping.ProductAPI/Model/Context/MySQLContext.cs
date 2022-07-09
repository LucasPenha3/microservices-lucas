using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(){}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for(int i = 3; i <= 20; i++)
            {
                _ = modelBuilder.Entity<Product>().HasData(new Product
                {
                    Id = i,
                    Name = "Produto " + i.ToString(),
                    Price = Math.Round(Convert.ToDecimal(10 * i), 2),
                    CategoryName = "Categoria produto " + i.ToString(),
                    image_url = "http://teste.com",
                    Description = "Descrição do produto " + i.ToString()
                });
            }
            
        }

    }
}
