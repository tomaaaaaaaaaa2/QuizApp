namespace QuizApp.Components.Model
{
    public struct QuizStruct
    {
        public string Text;
        public int Score;
        public QuestionType Type;
        public string Answer;
        public List<string>? Options;

        public QuizStruct(string text, int score, QuestionType type, string answer, List<string> options)
        {
            Text = text;
            Score = score;
            Type = type;
            Answer = answer;
            Options = options;
        }

        public QuizStruct(string text, int score, QuestionType type, string answer)
        {
            Text = text;
            Score = score;
            Type = type;
            Answer = answer;
        }
    }
}
