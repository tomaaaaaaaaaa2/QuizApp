using QuizApp.Components.Model;

namespace QuizApp.Components.Logic
{
    public class QuestionManager
    {
        public List<Question> Questions { get; } = new();

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
    }
}
