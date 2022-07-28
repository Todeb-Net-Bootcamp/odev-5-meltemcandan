using Microsoft.EntityFrameworkCore;
using PatikaDev.Models.Entities;
namespace PatikaDev.DAL.Contexts
{
    /// <summary>
    /// E-Ticaret uygulamamızın ürün, sepet ve müşteri sınıflarının DbSet işlemleri yapılmıştır.
    /// </summary>
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options) 
        {

        }
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
    }
}
