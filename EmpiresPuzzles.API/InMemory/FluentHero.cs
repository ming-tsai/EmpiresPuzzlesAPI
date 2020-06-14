using System.Collections.Generic;
using System.Linq;
using EmpiresPuzzles.API.Fluents;
using EmpiresPuzzles.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpiresPuzzles.API.InMemory
{
    public class FluentHero : IFluentHero
    {
        private static IEnumerable<Hero> heroesData = new List<Hero>()
            {
                new Hero(){
                    Name = "Hikaru",
                    Stars = 1
                }
                ,new Hero(){
                    Name = "Sharan",
                    Stars = 1
                }
                ,new Hero()
                {
                    Name = "Aife",
                    Stars = 1,
                }
                ,new Hero()
                {
                    Name = "Brand",
                    Stars = 1,
                    HeroSpeed = new HeroSpeed()
                    {
                        Id = 1,
                        Description = "TestData"
                    }
                }
            };
            
        private IEnumerable<Hero> heroes;
        public FluentHero()
        {
            heroes = heroesData;
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