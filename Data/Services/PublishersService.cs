using PCGameShoppingApp.Data.Base;
using PCGameShoppingApp.Models;

namespace PCGameShoppingApp.Data.Services
{
    public class PublishersService : EntityBaseRepository<Publisher>, IPublishersService
    {
        public PublishersService(AppDbContext appDbContext) : base(appDbContext) { }
    }
} 