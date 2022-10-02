using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class JWTService : IJWTService
    {
        private readonly IJWTRepository jwtRepository;
        public JWTService(IJWTRepository _jwtRepository)
        {
            jwtRepository = _jwtRepository;
        }
        public String Auth(LoginDTO loginDTO)
        {
            var result = jwtRepository.Auth(loginDTO);
            if (result == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("The Secrity Key Is My Name Saif Karmi");  //You can use any thing here As a key  (Long Key)
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.GroupSid,result.Id),
                        new Claim(ClaimTypes.Name,result.UserName),
                        new Claim(ClaimTypes.Role,result.RoleName),
                        new Claim(ClaimTypes.Sid ,result.blockStatus),


                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)

                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);

            }
        }
    }
}
