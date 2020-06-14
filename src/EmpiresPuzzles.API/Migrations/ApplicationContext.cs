using EmpiresPuzzles.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpiresPuzzles.API.Migrations
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) { }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<HeroSpeed> HeroSpeeds { get; set; }
    }
}