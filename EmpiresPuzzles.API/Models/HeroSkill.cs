using System.Collections.Generic;

namespace EmpiresPuzzles.API.Models
{
    public class HeroSkill
    {
        public string Name { get; set; }
        public string ManaSpeed { get; set; }
        public IEnumerable<string> MaxLevelEffect { get; set; }
    }
}