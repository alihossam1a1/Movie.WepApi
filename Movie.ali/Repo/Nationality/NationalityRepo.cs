using Moviee.ali.DTO.Get;
using Moviee.ali.Repo.Nationality;
using Moviee.ali.modes;
using Moviee.ali.Data;

namespace Moviee.ali.Repo.Nationality
{
    public class NationalityRepo : INationalityRepo
    {
        private readonly AppDbContext _Context;

        public NationalityRepo(AppDbContext context)
        {
            _Context = context;
        }

        public void addNationality(NationalityDtoGet nationalityDtoGet)
        {
            modes.Nationality a = new modes.Nationality
            {
                Name = nationalityDtoGet.Name
            };
            _Context.Nationality.Add(a);
            _Context.SaveChanges();
           
        }

        public bool Delete(int id)
        {
            var res = _Context.Nationality.FirstOrDefault(x=> x.Id == id);
            if (res != null)
            {
                _Context.Nationality.Remove(res);
                _Context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
