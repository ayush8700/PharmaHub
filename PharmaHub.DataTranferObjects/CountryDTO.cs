using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.DataTranferObjects
{
    public class GetCountryDTO
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
    }

    public class AddCountryDTO
    {
        public string CountryName { get; set; } = null!;
    }
}
