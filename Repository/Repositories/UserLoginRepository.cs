using Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserLoginRepository : IUserLoginRepository
    {
        private readonly RestaurantContext _ctx;
        public UserLoginRepository(RestaurantContext ctx) => _ctx = ctx;

        public async Task<bool> ExistsAsync(string email)
        {
            return await _ctx.User
                .AnyAsync(x => x.Active && x.Email.ToUpper() == email.ToUpper());
        }

        public async Task<UserEf> GetUserAsync(string email)
        {
            return await _ctx.User
                .FirstAsync(x => x.Email.ToUpper() == email.ToUpper());
        }

    }
}
