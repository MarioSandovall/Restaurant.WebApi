using Model.Models.Login;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IAccountManager
    {
        Task<bool> ExistsAsync(string email);

        Task<UserAccount> GetAccountAsync(string email);
    }
}
