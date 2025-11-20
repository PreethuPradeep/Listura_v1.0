using Listura_v1._0.Models;
using Listura_v1._0.Models.DTOs;

namespace Listura_v1._0.Services.Interfaces
{
    public interface IAuthService
    {
        Task<string> Register(RegisterDto dto);
        Task<string> Login(LoginDto dto);
        string CreateToken(AppUser user, IList<string> roles);
    }
}
