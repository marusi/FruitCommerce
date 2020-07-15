using System;
using System.Threading.Tasks;
using FruitCommerce.Domain.Commands;
using FruitCommerce.Domain.Core.Dtos;
using FruitCommerce.Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FruitCommerce.Controllers
{

    public class CustomerController : ApiControllerBase

    {
        public CustomerController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Get customer by id
        /// </summary>
        /// <param name="id">Id of customer</param>
        /// <returns>Customer information</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CustomerDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<CustomerDto>> GetCustomerAsync(Guid id)
        {
            return Single(await QueryAsync(new GetCustomerQuery(id)));
        }

        /// <summary>
        /// Create new customer
        /// </summary>
        /// <param name="command">Info of customer</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateCustomerAsync([FromBody] CreateCustomerCommand command)
        {
            return Ok(await CommandAsync(command));
        }
    }
}