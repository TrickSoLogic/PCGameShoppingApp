using PCGameShoppingApp.Data.Base;
using PCGameShoppingApp.Data.ViewModels;
using PCGameShoppingApp.Models;

namespace PCGameShoppingApp.Data.Services
{
    public interface IGamesService : IEntityBaseRepository<Game>
    {
        Task<Game> GetGameByIdAsync(int id);
        Task<NewGameDropdownsVM> GetNewGameDropdownsValuesAsync();
        Task AddNewGameAsync(NewGameVM newGameVM);
        Task UpdateGameAsync(NewGameVM newGameVM);
        Task RemoveGameAsync(int id);
    }
} 