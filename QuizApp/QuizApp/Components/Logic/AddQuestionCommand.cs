using QuizApp.Components.Model;

namespace QuizApp.Components.Logic;

public class AddQuestionCommand(QuestionManager questionManager, Question question) : ICommand
{

    public void Execute()
    {
        questionManager.AddQuestion(question);
    }

    public void Undo()
    {
        questionManager.DeleteQuestion(question);
    }
}
