using FlexibleAutomationTool.BL.IServices;

namespace FlexibleAutomationTool.BL.Services
{
    public class Invoker
    {
        private ICommand _command;
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
            _commandHistory.Push(_command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Any())
            {
                var lastCommand = _commandHistory.Pop();
                lastCommand.Undo();
            }
        }
    }
}
