using Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly RestaurantContext _ctx;
        public LoginRepository(RestaurantContext ctx) => _ctx = ctx;


        public async Task<bool> ExistsAsync(string email, string password)
        {
            return await _ctx.User.AnyAsync(x => x.Active &&
                x.Email.ToUpper() == email.ToUpper() &&
                x.Password.ToUpper() == password.ToUpper());
        }

        public async Task<UserEf> GetUserAsync(string email, string password)
        {
            return await _ctx.User.AsNoTracking()
                .Include(x => x.UserRoles)
                .ThenInclude(x => x.Role)
                .FirstAsync(x => x.Active &&
                   x.Email.ToUpper() == email.ToUpper() &&
                   x.Password.ToUpper() == password.ToUpper());
        }

    }
}
