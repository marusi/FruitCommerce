using MediatR;

namespace FruitCommerce.Domain.Queries
{
   public abstract class QueryBase<TResult> : IRequest<TResult> where TResult : class 
    {
    }
}
