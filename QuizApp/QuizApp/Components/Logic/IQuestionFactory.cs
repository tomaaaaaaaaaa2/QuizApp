using QuizApp.Components.Model;

namespace QuizApp.Components.Logic
{
    public interface IQuestionFactory
    {
        Question CreateQuestion(QuizStruct quizStruct);
    }
}
