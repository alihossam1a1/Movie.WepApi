using Moviee.ali.modes;
using System.ComponentModel.DataAnnotations;

namespace Moviee.ali.modes
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateOnly ReleaseYear { get; set; }
        public List<Director>? Directors { get; set; }
        public Category? Category { get; set; }
    }
}
