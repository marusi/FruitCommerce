using System;
using System.ComponentModel.DataAnnotations;
using FruitCommerce.Domain.Core.Dtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FruitCommerce.Domain.Queries
{
   public class GetCustomerQuery : QueryBase<CustomerDto>
    {
        public GetCustomerQuery()
        {
        }

        [JsonConstructor]
        public GetCustomerQuery(Guid customerId)
        {
            CustomerId = customerId;
        }

        [JsonProperty("id")]
        [Required]
        public Guid CustomerId { get; set; }
    }
}
