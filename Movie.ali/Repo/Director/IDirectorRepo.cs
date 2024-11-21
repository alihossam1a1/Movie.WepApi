using Moviee.ali.DTO.Add;
using Moviee.ali.DTO.Get;


namespace Moviee.ali.Repo.Director
{
    public interface IDirectorRepo
    {
        void addmovie( DirectorOnlyDtoAdd directorOnlyDtoAdd);
        bool update(int id , DirectorDtoGet directorDtoGet);
        bool delete(int id);
    }
}
