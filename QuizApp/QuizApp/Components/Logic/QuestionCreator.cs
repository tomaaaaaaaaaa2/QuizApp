using QuizApp.Components.Model;

namespace QuizApp.Components.Logic
{
    public static class QuestionCreator
    {
        public static Question CreateQuestion(QuizStruct quizStruct)
        {
            return quizStruct.Type switch
            {
                QuestionType.Choice => new ChoiceQuestion
                {
                    Text = quizStruct.Text,
                    Score = quizStruct.Score,
                    CorrectOptionIndex = int.Parse(quizStruct.Answer),
                    Options = quizStruct.Options
                },
                QuestionType.Text => new TextQuestion
                {
                    Text = quizStruct.Text,
                    Score = quizStruct.Score,
                    CorrectAnswer = quizStruct.Answer
                },
                _ => throw new InvalidOperationException("不明な質問タイプです。")
            };
        }
    }
}