using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.DataTranferObjects
{
    public class GetCategoriesDTO
    {
        public byte CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class AddCategoryDTO
    {
        public string CategoryName { get; set; }
    }
}
