using ASRMDesktopUserInterface.Models;
using System.Threading.Tasks;

namespace ASRMDesktopUI.Library.Api
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}