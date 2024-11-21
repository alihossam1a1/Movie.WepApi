using Moviee.ali.DTO.Add;
using Moviee.ali.modes;
using System.ComponentModel.DataAnnotations;

namespace Moviee.ali.DTO.Get
{
    public class MovieDtoGet
    {
        [Required]
        public string Title { get; set; }
        public DateOnly ReleaseYear { get; set; }
        public List<DirectorDtoAdd> DirectorsDtoAdd { get; set; }
        public Category Category { get; set; }
    }
}
