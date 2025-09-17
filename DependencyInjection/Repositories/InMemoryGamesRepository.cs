
namespace DependencyInjection.Repositories;

public class InMemoryGamesRepository : IGamesRepository
{
    List<GameDto> _games = [];
    public void Create(GameDto game)
    {
        _games = [];
    }

    public void Delete(int id)
    {
        _games.RemoveAll(g => g.Id == id);
    }

    public GameDto? Get(int id)
    {
        return _games.Find(g => g.Id == id);
    }

    public IEnumerable<GameDto> GetAll()
    {
        Console.WriteLine("Called GetAll from InMemoryGamesRepo");
        return _games;
    }

    public void Update(GameDto game)
    {
        var i = _games.FindIndex(g => g.Id == game.Id);
        _games[i] = game;
    }
}
