using Basic_Games_Shelf.Models;

namespace Basic_Games_Shelf.IServices
{
    public interface IGamesService
    {
        Task<IEnumerable<Games>> GetGames();
        Task<Games> GetGames(int id);
        Task<Games> PutGames(int id, Games games);
        Task<Games> PostGames(Games games);
        Task<Games> DeleteGames(int id);
        bool GamesExists(int id);
    }
}
