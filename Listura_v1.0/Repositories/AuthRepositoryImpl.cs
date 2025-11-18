using Listura_v1._0.Models;
using Listura_v1._0.Models.DTOs;
using Listura_v1._0.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Listura_v1._0.Repositories
{
    public class AuthRepositoryImpl : IAuthRepository
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        public AuthRepositoryImpl(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<string> LoginAsync(LoginDto dto)
        {
            var user = await userManager.FindByEmailAsync(dto.Email);
            if (user == null) return "Invalid Credentials!";
            var result = await signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
            if (!result.Succeeded) return "Invalid Credentials";
            return "Logged In";
        }

        public async Task<string> RegisterAsync(RegisterDto dto)
        {
            var user = new AppUser
            {
                DisplayName = dto.DisplayName,
                Email = dto.Email
            };
            var result = await userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded)
            {
                return string.Join(';', result.Errors.Select(e => e.Description));
            }
            return "Registered";
        }
    }
}
