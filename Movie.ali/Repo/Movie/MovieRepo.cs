using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Moviee.ali.Data;
using Moviee.ali.DTO.Add;
using Moviee.ali.DTO.Get;
using Moviee.ali.modes;



namespace Moviee.ali.Repo.Movie
{
    public class MovieRepo : IMovieRepo
    {
        private readonly AppDbContext _Context;

        public MovieRepo(AppDbContext context)
        {
            _Context = context;
        }

        public void addmovie(MovieDtoGet movieDtoGet)
        {
            modes.Movie a = new modes.Movie
            {
                Title = movieDtoGet.Title,
                ReleaseYear = movieDtoGet.ReleaseYear,
                Category = new modes.Category
                {
                    Name = movieDtoGet.Category.Name,
                },
           
                Directors = movieDtoGet.DirectorsDtoAdd.Select(x => new modes.Director
                {
                    Name = x.Name,
                    Email = x.Email,
                    Contact = x.Contact,
                    Nationality = new modes.Nationality
                    {
                        Name = x.NationalityDtoAdd.Name
                    }
                }).ToList(),
            };
            _Context.Movies.Add(a);
            _Context.SaveChanges();
        }

        public MovieDtoGet Get(int id)
        {
            var res = _Context.Movies
                  .Include(x => x.Category)
                   .Include(x => x.Directors)
                   .ThenInclude(x => x.Nationality).FirstOrDefault(x => x.Id == id);
            if (res == null)
            {
                return null;
            }
            return new MovieDtoGet
            {
                Title = res.Title,
                ReleaseYear = res.ReleaseYear,
                Category = new modes.Category
                {
                    Name = res.Category.Name,
                },
                DirectorsDtoAdd = res.Directors.Select(x => new DirectorDtoAdd
                {
                    Name = x.Name,
                    Contact = x.Contact,
                    Email = x.Email,
                    NationalityDtoAdd = new NationalityDtoAdd
                    {
                        Name = x.Nationality.Name,
                    }
                }).ToList(),
            };
        }

        public List<MovieDtoGet> Getall()
        {
            var res = _Context.Movies
                 .Include(x => x.Category)
                 .Include(x => x.Directors)
                 .ThenInclude(x => x.Nationality).Select(x => new MovieDtoGet
                 {
                     Title = x.Title,
                     ReleaseYear = x.ReleaseYear,
                     Category = new modes.Category
                     {
                         Name = x.Category.Name
                     },
                     DirectorsDtoAdd = x.Directors.Select(x => new DirectorDtoAdd
                     {
                         Name = x.Name,
                         Email = x.Email,
                         Contact = x.Contact,
                         NationalityDtoAdd = new NationalityDtoAdd
                         {
                             Name = x.Nationality.Name,
                         }
                     }).ToList()
                 }).ToList();
            return res;
        }
    }
}
