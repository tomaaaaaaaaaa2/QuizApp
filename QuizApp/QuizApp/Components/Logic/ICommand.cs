namespace QuizApp.Components.Logic;

public interface ICommand
{
    void Execute();
    void Undo();
}
