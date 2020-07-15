using System.Threading.Tasks;

namespace FruitCommerce.Data.Services
{
   public interface ICustomerRepository : IRepository<Domain.Core.Models.Customer>
    {
        Task<bool> EmailExistAsync(string email);
    }
}
