using Listura_v1._0.Models.DTOs;
using Listura_v1._0.Repositories.Interfaces;
using Listura_v1._0.Services.Interfaces;

namespace Listura_v1._0.Services
{
    public class AuthServiceImpl : IAuthService
    {
        IAuthRepository authRepository;
        public AuthServiceImpl(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }
        public async Task<string> Register(RegisterDto dto)
        {
            return await authRepository.RegisterAsync(dto);
        }

        public async Task<string> Login(LoginDto dto)
        {
            return await authRepository.LoginAsync(dto);
        }
    }
}
