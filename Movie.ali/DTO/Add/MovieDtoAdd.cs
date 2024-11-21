using System.ComponentModel.DataAnnotations;

namespace Moviee.ali.DTO.Add
{
    public class MovieDtoAdd
    {
        [Required]
        public string Title { get; set; }
        public DateOnly ReleaseYear { get; set; }

    }
}
