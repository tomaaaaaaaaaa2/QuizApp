namespace QuizApp.Components.Model
{
    public abstract class Question
    {
        public string Text { get; set; }
        public int Score { get; set; }
        public abstract QuestionType Type { get; }
    }
}