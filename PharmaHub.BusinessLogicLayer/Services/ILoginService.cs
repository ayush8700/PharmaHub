using PharmaHub.DataTranferObjects;

namespace PharmaHub.BusinessLogicLayer.Services
{
    public interface ILoginService
    {
        SaveLoginDto Login(string emailId, string password);
    }
}
