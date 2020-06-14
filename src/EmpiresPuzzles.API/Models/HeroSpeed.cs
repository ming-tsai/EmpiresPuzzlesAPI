using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpiresPuzzles.API.Models
{
    [Table("herospeeds")]
    public class HeroSpeed
    {
        [Column("id"), Key]
        public int Id { get; set; }
        [Column("description")]
        public string Description { get; set; }
    }
}