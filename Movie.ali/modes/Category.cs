using Moviee.ali.DTO.Add;
using System.ComponentModel.DataAnnotations;

namespace Moviee.ali.modes
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Movie>? Movies { get; set; }

    }
}
