using QuizApp.Components.Model;

namespace QuizApp.Components.Logic;

public class DeleteQuestionCommand(QuestionManager questionManager, Question question) : ICommand
{

    public void Execute()
    {
        questionManager.DeleteQuestion(question);
    }

    public void Undo()
    {
        questionManager.AddQuestion(question);
    }
}
