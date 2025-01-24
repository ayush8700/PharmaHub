using PharmaHub.DataTranferObjects;

namespace PharmaHub.DataAccessLayer.Repositories
{
    public interface ILoginRepository
    {
        GetLoginDto Login(string emailId, string password);
        bool Register(AddLoginDto addLoginDTO);
    }
}
