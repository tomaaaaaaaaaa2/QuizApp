
namespace QuizApp.Components.Logic;

internal interface ILeaderBoardBroadcaster
{
    Task UpdateScoreAsync(string roomId, string playerName, int totalScore, CancellationToken token);
}
