using EmpiresPuzzles.API.Models;
using System.Collections.Generic;

namespace EmpiresPuzzles.API.Interfaces
{
    public interface IHeroService
    {
        IEnumerable<Hero> GetAll();
        Hero GetBy(string name);
    }
}