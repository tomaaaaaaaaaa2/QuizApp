namespace QuizApp.Components.Model
{
    public class Room(string roomName, List<Question> questionList)
    {
        public string RoomName { get; } = roomName;
        public string ID { get; } = Guid.NewGuid().ToString();
        public List<Question> QuestionList { get; } = questionList;
    }
}