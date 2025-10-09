
namespace QuizApp.Components.Logic;

internal interface ILeaderBoardStore
{
    Task AddScoreAsync(string roomId, string playerName, int score, CancellationToken token);
    Task<int> GetTotalScoreAsync(string roomId, string playerName, CancellationToken token);
    Task<List<string>> GetRegisteredNickNamesAsync(string roomId, CancellationToken token);
}
