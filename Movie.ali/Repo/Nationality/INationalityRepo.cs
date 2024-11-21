using Moviee.ali.DTO.Get;

namespace Moviee.ali.Repo.Nationality
{
    public interface INationalityRepo
    {
        void addNationality(NationalityDtoGet  nationalityDtoGet);
        bool Delete (int id);
    }
}
