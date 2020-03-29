namespace EmpiresPuzzles.API.Models
{
    public class Hero
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string ImageURI { get; set; }
        public int Star { get; set; }
        public string Gender { get; set; }
        public HeroType Type { get; set; }
        public HeroStatus BaseStatus { get; set; }
        public HeroStatus MaxedStatus { get; set; }
        public HeroSkill Skill { get; set; }
    }
}