
namespace QuizApp.Components.Logic;

internal interface ILeaderBoardStore
{
    Task AddScoreAsync(string roomId, string playerName, int score, CancellationToken token);
    Task<int> GetTotalScoreAsync(string roomId, string playerName, CancellationToken token);
}
