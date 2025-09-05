namespace QuizApp.Components.Model
{
    public class ChoiceQuestion : Question
    {
        public override QuestionType Type => QuestionType.Choice;

        public List<string> Options { get; init; } = new();
        public int CorrectOptionIndex { get; init; }
    }
}
