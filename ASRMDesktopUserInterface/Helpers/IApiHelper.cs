using ASRMDesktopUserInterface.Models;
using System.Threading.Tasks;

namespace ASRMDesktopUserInterface.Helpers
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}