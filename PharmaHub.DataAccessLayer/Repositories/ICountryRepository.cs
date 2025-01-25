using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaHub.DataTranferObjects;

namespace PharmaHub.DataAccessLayer.Repositories
{
    public interface ICountryRepository
    {
        GetCountryDTO GetCountries ();
        GetCountryDTO GetCountryById(int countryId);
        int AddCountry(AddCountryDTO country);
        int UpdateCountry(AddCountryDTO country);
        int DeleteCountry(int countryId);

    }
}
