using FruitCommerce.Domain.Core.Dtos;

namespace FruitCommerce.Service.Dxos
{
   public interface ICustomerDxos
    {
        CustomerDto MapCustomerDto(Domain.Core.Models.Customer customer);
    }
}
