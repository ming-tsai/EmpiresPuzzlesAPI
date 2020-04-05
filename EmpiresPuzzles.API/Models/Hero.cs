using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpiresPuzzles.API.Models
{
    [Table("heroes")]
    public class Hero
    {
        [Column("id"),Key]
        public int Id { get; set; }
        [Column("color")]
        public string Color { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("teamcost")]
        public int TeamCost { get; set; }
        [Column("stars")]
        public int Stars { get; set; }
        [Column("speedid")]
        public int SpeedId { get; set; }
        [ForeignKey("SpeedId")]
        public HeroSpeed HeroSpeed { get; set; }
        [Column("maxpower")]
        public int MaxPower { get; set; }
        [Column("maxattack")]
        public int MaxAttack { get; set; }
        [Column("maxdefense")]
        public int MaxDefense { get; set; }
        [Column("maxhealth")]
        public int MaxHealth { get; set; }
        [Column("maxlevel")]
        public int MaxLevel { get; set; }
        [Column("fandomwikiuri")]
        public string FandomWikiURI { get; set; }
    }
}