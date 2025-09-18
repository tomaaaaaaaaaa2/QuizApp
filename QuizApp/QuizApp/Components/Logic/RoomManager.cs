using QuizApp.Components.Model;

namespace QuizApp.Components.Logic
{
    public class RoomManager
    {
        public List<Room> Rooms { get; } = new();

        public event Action? OnChange;

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
            NotifyStateChanged();
        }

        public void DeleteRoom(Room room)
        {
            Rooms.Remove(room);
            NotifyStateChanged();
        }

        public Room GetRoom(string roomId)
        {
            if (!Rooms.Any(room => room.ID == roomId))
            {
                throw new Exception("指定されたルームは存在しません。");
            }

            return Rooms.First(room => room.ID == roomId);
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
