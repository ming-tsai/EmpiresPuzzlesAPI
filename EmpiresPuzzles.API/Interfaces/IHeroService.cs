using System.Collections.Generic;
using EmpiresPuzzles.API.Models;

namespace EmpiresPuzzles.API.Interfaces
{
    public interface IHeroService
    {
        IEnumerable<Hero> GetAll();
        Hero GetBy(string name);
    }
}