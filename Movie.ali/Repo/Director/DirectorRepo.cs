using Microsoft.EntityFrameworkCore;
using Moviee.ali.Data;
using Moviee.ali.DTO.Add;
using Moviee.ali.DTO.Get;

namespace Moviee.ali.Repo.Director
{
    public class DirectorRepo : IDirectorRepo
    {
        private readonly AppDbContext _Context;

        public DirectorRepo(AppDbContext context)
        {
            _Context = context;
        }

        public void addmovie( DirectorOnlyDtoAdd directorOnlyDtoAdd)
        {

            modes.Director b = new modes.Director
            {
                Name = directorOnlyDtoAdd.Name,
                Email = directorOnlyDtoAdd.Email,
                Contact = directorOnlyDtoAdd.Contact,
                Nationality = new modes.Nationality
                {
                    Name =directorOnlyDtoAdd.NationalityDtoAdd.Name,
                }
            };
            _Context.Directors.Add(b);
            _Context.SaveChanges();
            
        }

        public bool delete(int id)
        {
           var res = _Context.Directors.FirstOrDefault(d => d.Id == id);
            if (res != null)
            {
                _Context.Directors.Remove(res);
                _Context.SaveChanges() ;
                return true;
            }
            return false;
        }

        public bool update(int id, DirectorDtoGet directorDtoGet)
        {
            var res = _Context.Directors.Include(x=>x.Movies).Include(x=>x.Nationality).FirstOrDefault(x=>x.Id==id);
            if (res != null)
            { 
                res.Name = directorDtoGet.Name;
                res.Email = directorDtoGet.Email;
                res.Contact = directorDtoGet.Contact;
                res.Movies =directorDtoGet.MoviesDtoAdd.Select(x=> new modes.Movie
                {
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                }).ToList();
                res.Nationality = new modes.Nationality
                {
                    Name = res.Nationality.Name, 

                };

                _Context.Directors.Update(res);
                _Context.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
