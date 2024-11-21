using Moviee.ali.DTO.Add;
using System.ComponentModel.DataAnnotations;

namespace Moviee.ali.DTO.Get
{
    public class CategoryDtoGet
    {
        [Required]
        public string Name { get; set; }
        public List<MovieDtoAdd> MoviesDtoAdd { get; set; }
    }
}
