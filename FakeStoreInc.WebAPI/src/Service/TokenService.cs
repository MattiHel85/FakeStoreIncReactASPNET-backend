using System.IdentityModel.Tokens.Jwt;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using Microsoft.IdentityModel.Tokens;

namespace FakeStoreInc.WebAPI.src.Service
{
    public class TokenService : ITokenService
    {
        IConfiguration _config;
        public TokenService(IConfiguration config)
        {
            _config = config;
        }
        public string GenerateToken(User user)
        {
            var issuer = _config.GetSection("jwt:Issuer").Value;
            var claims = new List<Claim>{
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
            };
            var audience = _config.GetSection("Jwt:Audience").Value;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("Jwt:Key").Value!));
            var signingKey = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = issuer,
                Audience = audience,
                Expires = DateTime.Now.AddDays(2),
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = signingKey
            };
            var token = tokenHandler.CreateToken(descriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}