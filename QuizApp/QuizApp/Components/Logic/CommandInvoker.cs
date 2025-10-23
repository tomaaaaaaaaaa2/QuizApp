namespace QuizApp.Components.Logic;

public class CommandInvoker
{
    private readonly Stack<ICommand> _history = new();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _history.Push(command);
    }

    public void Undo()
    {
        if (_history.Count > 0)
        {
            _history.Pop().Undo();
        }
    }
}
