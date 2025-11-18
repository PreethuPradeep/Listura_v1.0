using Listura_v1._0.Models.DTOs;

namespace Listura_v1._0.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        Task<string> RegisterAsync(RegisterDto dto);
        Task<string> LoginAsync(LoginDto dto);
    }
}
