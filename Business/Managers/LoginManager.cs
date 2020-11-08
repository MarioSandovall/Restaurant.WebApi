using AutoMapper;
using Business.Interfaces;
using Model.Models.Login;
using Repository.Interfaces;
using Service.Interfaces;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class LoginManager : ILoginManager
    {
        private readonly IMapper _mapper;
        private readonly ILoginService _loginService;
        private readonly ILoginRepository _loginRepository;
        public LoginManager(
            IMapper mapper,
            ILoginService loginService,
            ILoginRepository loginRepository)
        {
            _mapper = mapper;
            _loginService = loginService;
            _loginRepository = loginRepository;
        }

        public async Task<bool> ExistsAsync(string email, string password)
        {
            return await _loginRepository.ExistsAsync(email, password);
        }

        public async Task<UserLogin> GetUserAsync(string email, string password)
        {
            var entity = await _loginRepository.GetUserAsync(email, password);

            var userLogin = _mapper.Map<UserLogin>(entity);

            userLogin.Token = _loginService.BuildToken(userLogin);

            return userLogin;
        }

    }
}
