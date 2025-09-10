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

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
