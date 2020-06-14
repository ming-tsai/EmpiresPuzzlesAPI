using System.Collections.Generic;
using EmpiresPuzzles.API.Models;

namespace EmpiresPuzzles.API.Fluents
{
    public interface IFluentHero
    {
        IFluentHero WithName(string name);
        IEnumerable<Hero> Get();
    }
}