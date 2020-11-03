using AutoMapper;
using Business.Interfaces;
using Model.Models.Login;
using Repository.Interfaces;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class UserLoginManager : IUserLoginManager
    {
        private readonly IMapper _mapper;
        private readonly IUserLoginRepository _repository;
        public UserLoginManager(
            IMapper mapper,
            IUserLoginRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> ExistsAsync(string email)
        {
            return await _repository.ExistsAsync(email);
        }

        public async Task<UserAccount> GetAccountAsync(string email)
        {
            var entity = await _repository.GetUserAsync(email);

            return _mapper.Map<UserAccount>(entity);
        }

    }
}
