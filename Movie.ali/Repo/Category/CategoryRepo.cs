using Moviee.ali.Data;
using Moviee.ali.DTO.Add;
using Moviee.ali.DTO.Get;
using Moviee.ali.modes;

namespace Moviee.ali.Repo.Category
{
    public class CategotyRepo : ICategoryRepo
    {
        private readonly AppDbContext _Context;
        public CategotyRepo(AppDbContext context)
        {
            _Context = context;
        }


        public void addcategory(CategoryDtoAdd categoryDtoAdd)
        {
            modes.Category a = new modes.Category
            {
                Name = categoryDtoAdd.Name
            };
            _Context.Category.Add(a);
            _Context.SaveChanges();
        }

        public bool updatecategory(int id, CategoryDtoAdd categoryDtoAdd)
        {
            var res = _Context.Category.FirstOrDefault(c => c.Id == id);
            if (res != null)
            {
                res.Name = categoryDtoAdd.Name;
                
                _Context.Category.Update(res);
                _Context.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
