using System;
using System.Threading;
using System.Threading.Tasks;
using FruitCommerce.Data.Services;
using FruitCommerce.Domain.Core.Dtos;
using FruitCommerce.Domain.Queries;
using FruitCommerce.Service.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FruitCommerce.Service.Services
{
   public class GetCustomerHandler : IRequestHandler<GetCustomerQuery, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerDxos _customerDxos;
        private readonly ILogger _logger;

        public GetCustomerHandler(ICustomerRepository customerRepository, ICustomerDxos customerDxos, ILogger<GetCustomerHandler> logger)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
            _customerDxos = customerDxos ?? throw new ArgumentNullException(nameof(customerDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<CustomerDto> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetAsync(e => e.Id == request.CustomerId);

            if (customer != null)
            {
                _logger.LogInformation($"You've got a request to get customer Id: {customer.Id}");
                var customerDto = _customerDxos.MapCustomerDto(customer);
                return customerDto;
            }

            return null;
        }
    }
}