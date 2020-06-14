using EmpiresPuzzles.API.Interfaces;
using EmpiresPuzzles.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmpiresPuzzles.API.InMemory
{
    public class HeroService : IHeroService
    {
        private static IEnumerable<Hero> Heroes = new List<Hero>()
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

        public IEnumerable<Hero> GetAll() => Heroes.OrderBy(h => h.Name);

        public Hero GetBy(string name) => Heroes.FirstOrDefault(h => h.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
    }
}