using QuizApp.Components.Model;

namespace QuizApp.Components.Logic
{
    public class QuestionManager
    {
        public List<Question> Questions { get; } = new();

        public event Action? OnChange;

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
            NotifyStateChanged();
        }

        public void DeleteQuestion(Question question)
        {
            Questions.Remove(question);
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
