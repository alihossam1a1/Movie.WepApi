using Moviee.ali.DTO.Add;
using System.ComponentModel.DataAnnotations;

namespace Moviee.ali.DTO.Get
{
    public class DirectorDtoGet
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public List<MovieDtoAdd> MoviesDtoAdd { get; set; }
        public NationalityDtoAdd NationalityDtoAdd { get; set; }
    }
}
