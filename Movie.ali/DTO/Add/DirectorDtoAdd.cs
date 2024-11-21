using Moviee.ali.DTO.Add;
using System.ComponentModel.DataAnnotations;

namespace Moviee.ali.DTO.Add
{
    public class DirectorDtoAdd
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public NationalityDtoAdd NationalityDtoAdd { get; set; }
    }
}
