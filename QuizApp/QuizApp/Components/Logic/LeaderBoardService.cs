
using Microsoft.AspNetCore.SignalR;
using QuizApp.Components.Hubs;

namespace QuizApp.Components.Logic;

internal class LeaderBoardService(IHubContext<LeaderBoardHub> hubContext) : ILeaderBoardBroadcaster
{
    public async Task UpdateScoreAsync(string roomId, string playerName, int totalScore, CancellationToken token)
    {
        await hubContext.Clients.All.SendAsync("ScoreUpdated", roomId, playerName, totalScore).ConfigureAwait(false);
    }
}
