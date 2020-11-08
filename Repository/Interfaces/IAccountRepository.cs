using Domain.Entities;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IAccountRepository
    {
        Task<bool> ExistsAsync(string email);

        Task<UserEf> GetUserAsync(string email);
    }
}
