
namespace QuizApp.Components.Logic;

internal class InMemoryLeaderBoardStore : ILeaderBoardStore
{
    private readonly Dictionary<string, Dictionary<string, int>> _dic = new();
    public Task AddScoreAsync(string roomId, string playerName, int score, CancellationToken token)
    {
        lock(_dic)
        {
            if (!_dic.ContainsKey(roomId))
            {
                _dic[roomId] = new Dictionary<string, int>();
            }
            if (!_dic[roomId].ContainsKey(playerName))
            {
                _dic[roomId][playerName] = 0;
            }

            _dic[roomId][playerName] += score;
        }

        return Task.CompletedTask;
    }

    public Task<int> GetTotalScoreAsync(string roomId, string playerName, CancellationToken token)
    {
        lock(_dic)
        {
            if (!_dic.ContainsKey(roomId) || !_dic[roomId].ContainsKey(playerName))
            {
                throw new KeyNotFoundException("not contained.");
            }

            return Task.FromResult(_dic[roomId][playerName]);
        }
    }

    public Task<List<string>> GetRegisteredNickNamesAsync(string roomId, CancellationToken token)
    {
        lock (_dic)
        {
            if (_dic.TryGetValue(roomId, out var roomScores))
            {
                return Task.FromResult(roomScores.Keys.ToList());
            }
            return Task.FromResult(new List<string>());
        }
    }
}
