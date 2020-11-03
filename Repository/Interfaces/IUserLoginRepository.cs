using Domain.Entities;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IUserLoginRepository
    {
        Task<bool> ExistsAsync(string email);

        Task<UserEf> GetUserAsync(string email);
    }
}
