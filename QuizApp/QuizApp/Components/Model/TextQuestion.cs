namespace QuizApp.Components.Model
{
    public class TextQuestion : Question
    {
        public override QuestionType Type => QuestionType.Text;
        public string CorrectAnswer { get; init; }
    }
}
