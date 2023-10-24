
namespace FlexibleAutomationTool.BL.IServices
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
