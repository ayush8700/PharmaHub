using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaHub.DataTranferObjects;

namespace PharmaHub.DataAccessLayer.Repositories
{
    public interface IStateRepository
    {
        GetStatesDTO GetStates();
        GetStatesDTO GetStateById(int stateId);
        int AddState(AddStatesDTO state);
        int UpdateState(AddStatesDTO state);
        int DeleteState(int stateId);

    }
}
