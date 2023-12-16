using PCGameShoppingApp.Data.Base;
using PCGameShoppingApp.Models;

namespace PCGameShoppingApp.Data.Services
{
    public class PlatformsService : EntityBaseRepository<Platform>, IPlatformsService
    {
        public PlatformsService(AppDbContext appDbContext) : base(appDbContext) { }
    }
}