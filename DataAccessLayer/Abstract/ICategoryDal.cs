using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category> 
    {
        List<Category> ListAllCategory();
        void CategoryAdd(Category category);
        void CategoryDelete(Category category);
        void UpdateCategory(Category category);
        Category GetById(int id);
    }
}
