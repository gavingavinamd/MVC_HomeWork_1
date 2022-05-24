using System.ComponentModel.DataAnnotations;

namespace MapleStory2.Models
{
    public class Monster
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Atk { get; set; }
        [Required]
        public int Hp { get; set; }

    }
}
