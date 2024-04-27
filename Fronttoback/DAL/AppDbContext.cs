using Fronttoback.Models;
using Microsoft.EntityFrameworkCore;

namespace Fronttoback.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
    }
}
