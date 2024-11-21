using Moviee.ali.DTO.Add;
using Moviee.ali.DTO.Get;

namespace Moviee.ali.Repo.Category
{
    public interface ICategoryRepo
    {
        void addcategory(CategoryDtoAdd categoryDtoAdd);
        bool updatecategory(int id,CategoryDtoAdd categoryDtoAdd);
    }
}
