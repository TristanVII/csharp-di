
namespace DependencyInjection.Repositories;
public interface IGamesRepository
{
    void Create(GameDto game);
    void Delete(int id);
    GameDto? Get(int id);
    IEnumerable<GameDto> GetAll();
    void Update(GameDto game);

}