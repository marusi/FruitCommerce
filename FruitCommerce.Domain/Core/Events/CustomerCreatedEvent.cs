using System;
using MediatR;

namespace FruitCommerce.Domain.Core.Events
{
   public class CustomerCreatedEvent : INotification
    {
        public Guid CustomerId { get; }

        public CustomerCreatedEvent(Guid customerId)
        {
            CustomerId = customerId;
        }
    }
}
