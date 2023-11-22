using RepositoryCommandService.Commands;

namespace RepositoryCommandService.Interface
{
    public interface IMediatorService
    {
        public Task SendCommand<T>(T command) where T : Command;
    }
}
