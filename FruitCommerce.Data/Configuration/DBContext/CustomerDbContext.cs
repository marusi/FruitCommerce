using System.Threading;
using System.Threading.Tasks;
using FruitCommerce.Data.Extension;
using Microsoft.EntityFrameworkCore;

namespace FruitCommerce.Data.Configuration.DBContext
{
   public class CustomerDbContext : DbContext
    {
        public DbSet<FruitCommerce.Domain.Core.Models.Customer> Customers { get; set; }

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations<CustomerDbContext>();
        }

        public override int SaveChanges()
        {
            this.AddAuditInfo();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            this.AddAuditInfo();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}