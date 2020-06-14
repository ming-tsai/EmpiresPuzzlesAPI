using System.Collections.Generic;
using System.Linq;
using EmpiresPuzzles.API.Migrations;
using EmpiresPuzzles.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpiresPuzzles.API.Fluents
{
    public class FluentHero : IFluentHero
    {
        IEnumerable<Hero> heroes;
        public FluentHero(ApplicationContext context)
        {
            heroes = context.Heroes.Include(h => h.HeroSpeed).OrderBy(h => h.Name);
        }

        public IFluentHero WithName(string name)
        {
            heroes = heroes.Where(h => EF.Functions.Like(h.Name, $"%{name}%"));
            return this;
        }

        public IEnumerable<Hero> Get() {
            return heroes;
        }
    }
}