using Model.Models.Login;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ILoginManager
    {
        Task<bool> ExistsAsync(string email, string password);

        Task<UserLogin> GetUserAsync(string email, string password);
    }
}
