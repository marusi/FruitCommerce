using Microsoft.EntityFrameworkCore;

namespace FruitCommerce.Data.Configuration.DBContext
{
    public class CustomerDbContextFactory : DesignTimeDbContextFactory<CustomerDbContext>
    {
        protected override CustomerDbContext CreateNewInstance(DbContextOptions<CustomerDbContext> options)
        {
            return new CustomerDbContext(options);
        }
    }
}