using QuizApp.Components.Model;

namespace QuizApp.Components.Logic;

internal class AnswerSubmissionService(ILeaderBoardStore leaderBoardStore, ILeaderBoardBroadcaster leaderBoardBroadcaster)
{
    public async Task SubmitAsync(string roomId, string playerName, Question question, string answer, CancellationToken token)
    {
        var score = answer == question.Answer ? question.Score : 0;
        await leaderBoardStore.AddScoreAsync(roomId, playerName, score, token).ConfigureAwait(false);
        var totalScore = await leaderBoardStore.GetTotalScoreAsync(roomId, playerName, token).ConfigureAwait(false);
        await leaderBoardBroadcaster.UpdateScoreAsync(roomId, playerName, totalScore, token).ConfigureAwait(false);
    }
}
