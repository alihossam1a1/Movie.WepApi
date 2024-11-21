using Moviee.ali.modes;
using System.ComponentModel.DataAnnotations;

namespace Moviee.ali.modes
{
    public class Director
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public List<Movie>? Movies { get; set; }
        public int Nationalityid { get; set; }
        public Nationality? Nationality { get; set; }
    }
}
