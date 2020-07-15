using MediatR;

namespace FruitCommerce.Domain.Commands
{
    public class CommandBase<T> : IRequest<T> where T : class
    {
    }
}
