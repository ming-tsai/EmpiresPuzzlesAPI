using System.Collections.Generic;
using EmpiresPuzzles.API.Interfaces;
using EmpiresPuzzles.API.Models;
using System.Linq;
using System;

namespace EmpiresPuzzles.API.Implementations.InMemoryService
{
    public class HeroService : IHeroService
    {
        private static IEnumerable<Hero> Heroes = new List<Hero>()
            {
                new Hero(){
                    Name = "Hikaru",
                    Profession = "Ninja Student",
                    ImageURI = "https://vignette.wikia.nocookie.net/empiresandpuzzles/images/4/47/Hikaru_-_Hero_Card.gif/revision/latest/scale-to-width-down/300?cb=20190410133433",
                    Star = 1,
                    Gender = "Female",
                    Type = new HeroType()
                    {
                        Element = "Holy",
                        Rarity = "Common",
                        Class = "Rogue"
                    },
                    BaseStatus = new HeroStatus()
                    {
                        Power = 143,
                        Attack = 178,
                        Defense = 152,
                        Health = 273
                    },
                    MaxedStatus = new HeroStatus()
                    {
                        Power = 213,
                        Attack = 222,
                        Defense = 189,
                        Health = 340
                    },
                    Skill = new HeroSkill()
                    {
                        Name = "Backstab",
                        ManaSpeed = "Fast",
                        MaxLevelEffect = new List<string>() { "Deals 265% damage to the target" }
                    }
                }
                ,new Hero(){
                    Name = "Sharan",
                    Profession = "Talented Trappert",
                    ImageURI = "https://vignette.wikia.nocookie.net/empiresandpuzzles/images/e/e5/Sharan_-_Hero_Card.gif/revision/latest/scale-to-width-down/300?cb=20190410024355",
                    Star = 1,
                    Gender = "Female",
                    Type = new HeroType()
                    {
                        Element = "Fire",
                        Rarity = "Common",
                        Class = "Ranger"
                    },
                    BaseStatus = new HeroStatus()
                    {
                        Power = 143,
                        Attack = 135,
                        Defense = 165,
                        Health = 359
                    },
                    MaxedStatus = new HeroStatus()
                    {
                        Power = 213,
                        Attack = 168,
                        Defense = 205,
                        Health = 448
                    },
                    Skill = new HeroSkill()
                    {
                        Name = "Minor Healing",
                        ManaSpeed = "Average",
                        MaxLevelEffect = new List<string>() { "Recovers 27% health for all allies" }
                    }
                }
                ,new Hero()
                {
                    Name = "Aife",
                    Profession = "Village Girl",
                    ImageURI = "https://vignette.wikia.nocookie.net/empiresandpuzzles/images/e/e5/Aife_-_Hero_Card.gif/revision/latest/scale-to-width-down/300?cb=20190410230356",
                    Star = 1,
                    Gender = "Female",
                    Type = new HeroType()
                    {
                        Element = "Nature",
                        Rarity = "Common",
                        Class = "Fighter"
                    },
                    BaseStatus = new HeroStatus()
                    {
                        Power = 140,
                        Attack = 168,
                        Defense = 147,
                        Health = 289
                    },
                    MaxedStatus = new HeroStatus()
                    {
                        Power = 209,
                        Attack = 209,
                        Defense = 183,
                        Health = 360
                    },
                    Skill = new HeroSkill()
                    {
                        Name = "Hacking Attack",
                        ManaSpeed = "Fast",
                        MaxLevelEffect = new List<string>() { "Deals 275% damage to the target" }
                    }
                }
                ,new Hero()
                {
                    Name = "Brand",
                    Profession = "Carefree Adventurer",
                    ImageURI = "https://vignette.wikia.nocookie.net/empiresandpuzzles/images/4/43/Brand_-_Hero_Card.gif/revision/latest/scale-to-width-down/300?cb=20190410224305",
                    Star = 1,
                    Gender = "Male",
                    Type = new HeroType()
                    {
                        Element = "Ice",
                        Rarity = "Common",
                        Class = "Fighter"
                    },
                    BaseStatus = new HeroStatus()
                    {
                        Power = 140,
                        Attack = 142,
                        Defense = 148,
                        Health = 355
                    },
                    MaxedStatus = new HeroStatus()
                    {
                        Power = 210,
                        Attack = 177,
                        Defense = 184,
                        Health = 443
                    },
                    Skill = new HeroSkill()
                    {
                        Name = "Fierce Slash",
                        ManaSpeed = "Average",
                        MaxLevelEffect = new List<string>() { "Deals 115% damage to all enemies" }
                    }
                }
            };

        public IEnumerable<Hero> GetAll()
        {
            return Heroes.OrderBy(h => h.Name);
        }

        public Hero GetBy(string name)
        {
            return Heroes.FirstOrDefault(h => h.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}