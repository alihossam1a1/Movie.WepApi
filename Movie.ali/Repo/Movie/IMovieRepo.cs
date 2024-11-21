using Moviee.ali.DTO.Get;



namespace Moviee.ali.Repo.Movie
{
    public interface IMovieRepo
    {
        List<MovieDtoGet> Getall();
        MovieDtoGet Get(int id);
        void addmovie(MovieDtoGet movieDtoGet);

    }
}
