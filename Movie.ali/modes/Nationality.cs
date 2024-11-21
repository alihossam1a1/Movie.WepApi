using System.ComponentModel.DataAnnotations;

namespace Moviee.ali.modes
{
    public class Nationality
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Director? Director { get; set; }
    }
}
