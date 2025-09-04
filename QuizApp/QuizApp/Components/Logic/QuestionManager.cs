using QuizApp.Components.Model;

namespace QuizApp.Components.Logic
{
    public class QuestionManager
    {
        private List<Question> _questions = new();

        public void AddQuestion(Question question)
        {
            _questions.Add(question);
        }
    }
}
