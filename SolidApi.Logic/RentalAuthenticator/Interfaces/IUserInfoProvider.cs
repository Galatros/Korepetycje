using System.Threading.Tasks;

namespace SolidApi.Logic.RentalAuthenticator.Interfaces
{
    public interface IUserInfoProvider
    {
        string GetUserCompany(string name);
    }
}
