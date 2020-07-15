using System;
using System.Threading.Tasks;
using FruitCommerce.Data.Configuration.DBContext;
using FruitCommerce.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace FruitCommerce.Data.Repositories
{
    public class CustomerRepository : Repository<Domain.Core.Models.Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> EmailExistAsync(string email)
        {
           return await ModelDbSets.AsNoTracking().AnyAsync(e => e.Email.Equals(email, StringComparison.CurrentCultureIgnoreCase));

        }
    }
}