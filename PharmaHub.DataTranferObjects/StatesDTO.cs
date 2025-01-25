using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.DataTranferObjects
{
    public class GetStatesDTO
    {
        public int StateId { get; set; }

        public int CountryId { get; set; }

        public string StateName { get; set; } = null!;
    }
    public class AddStatesDTO
    {
        public int CountryId { get; set; }

        public string StateName { get; set; } = null!;
    }

}
