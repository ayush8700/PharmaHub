using PharmaHub.DataTranferObjects;

namespace PharmaHub.DataAccessLayer.Repositories
{
    public interface ILoginRepository
    {
        GetLoginDto Login(string emailId, string password);
        int Register(AddLoginDto addLoginDTO);
    }
}
