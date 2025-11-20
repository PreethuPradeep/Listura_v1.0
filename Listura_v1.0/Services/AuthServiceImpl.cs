using Listura_v1._0.Models;
using Listura_v1._0.Models.DTOs;
using Listura_v1._0.Repositories.Interfaces;
using Listura_v1._0.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Listura_v1._0.Services
{
    public class AuthServiceImpl : IAuthService
    {
        IConfiguration config;
        IAuthRepository authRepository;
        UserManager<AppUser> userManager;
        public AuthServiceImpl(IAuthRepository authRepository,
            IConfiguration config,
            UserManager<AppUser> userManager)
        {
            this.authRepository = authRepository;
            this.config = config;
            this.userManager = userManager;
        }

        public async Task<string> Register(RegisterDto dto)
        {
            return await authRepository.RegisterAsync(dto);
        }

        public async Task<string> Login(LoginDto dto)
        {
            var result =  await authRepository.LoginAsync(dto);
            if (result != "Logged In") return null;
            var user = await userManager.FindByEmailAsync(dto.Email);
            var roles = await userManager.GetRolesAsync(user);
            return CreateToken(user, roles);
        }

        public string CreateToken(AppUser user, IList<string> roles)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim("displayName", user.DisplayName ?? ""),
            };
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var secretKey = config["JwtSettings:SecretKey"] ?? string.Empty;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: this.config["JwtSettings:Issuer"],
                audience: config["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(int.Parse(config["JwtSettings:ExpiryMinutes"])),
                signingCredentials: creds
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
