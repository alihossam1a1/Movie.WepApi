using Moviee.ali.DTO.Add;
using System.ComponentModel.DataAnnotations;

namespace Moviee.ali.DTO.Get
{
    public class NationalityDtoGet
    {
        [Required]
        public string Name { get; set; }
        public DirectorDtoAdd DirectorDtoAdd { get; set; }
    }
}
