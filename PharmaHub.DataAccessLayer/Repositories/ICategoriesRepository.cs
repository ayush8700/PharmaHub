using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaHub.DataTranferObjects;

namespace PharmaHub.DataAccessLayer.Repositories
{
    public interface ICategoriesRepository
    {
        GetCategoriesDTO GetAllCategory();
        GetCategoriesDTO GetCategoryById(byte categoryId);
        int AddCategory(AddCategoryDTO category);
        int UpdateCategory(AddCategoryDTO category);
    }
}
