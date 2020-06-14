using System.Collections.Generic;
using System.Linq;
using EmpiresPuzzles.API.Interfaces;
using EmpiresPuzzles.API.Migrations;
using EmpiresPuzzles.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpiresPuzzles.API.Implementations.Services
{
    public class HeroService : IHeroService
    {
        private ApplicationContext _context;
        public HeroService(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Hero> GetAll()
        {
            return _context.Heroes.Include(h => h.HeroSpeed).OrderBy(h => h.Name);
        }

        public Hero GetBy(string name)
        {
            return _context.Heroes.Include(h => h.HeroSpeed)
                        .FirstOrDefault(h => EF.Functions.Like(h.Name, $"%{name}%"));
        }
    }
}