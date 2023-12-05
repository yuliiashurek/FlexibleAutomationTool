using MediatR;
using RepositoryCommandService.Commands;
using RepositoryCommandService.Interface;

namespace Bus
{
    public class InMemoryBus : IMediatorService
    {
        private readonly IMediator _mediator;
        public InMemoryBus(IMediator mediator) 
        { 
            _mediator = mediator;
        }
        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}