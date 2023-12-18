using PCGameShoppingApp.Data.Base;
using PCGameShoppingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace PCGameShoppingApp.Data.Services
{
    public class DevelopersService : EntityBaseRepository<Developer>, IDevelopersService
    {
        public DevelopersService(AppDbContext appDbContext) : base(appDbContext) { }
    }
} 