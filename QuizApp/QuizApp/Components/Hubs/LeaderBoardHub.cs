using Microsoft.AspNetCore.SignalR;
using QuizApp.Components.Logic;

namespace QuizApp.Components.Hubs;

internal class LeaderBoardHub : Hub, ILeaderBoardBroadcaster
{
    public Task UpdateScoreAsync(string roomId, string playerName, int totalScore, CancellationToken token)
    {
        return Task.CompletedTask;
        //await Clients.All.SendAsync("ScoreUpdated", roomId, playerName, totalScore, token).ConfigureAwait(false);
    }
}
