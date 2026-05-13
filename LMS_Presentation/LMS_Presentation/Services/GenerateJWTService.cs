using LMS_Business_Layer.DTO;
using LMS_Data_Access_Layer.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LMS_CMS_PL.Services
{ 
    public class GenerateJWTService
    {
        private readonly IConfiguration configuration;

        public GenerateJWTService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public AuthResponseDto Generate_Jwt_Token(Employee employee,List<string> permissions)
        {
            var claims = new List<Claim>

            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),   // Unique identifier for the token 

                new Claim(ClaimTypes.NameIdentifier, employee.ID.ToString()),   

                new Claim(ClaimTypes.Name, employee.User_Name),  

                new Claim(ClaimTypes.Role, employee.Role.Name),  

                new Claim("RoleId", employee.Role_ID.ToString()) 
            };

            // Permissions
            foreach (var permission in permissions.Distinct())           // Ensure distinct permissions 
            {
               // claims.Add(new Claim("permission", permission));
                claims.Add(new Claim("perm", permission));
            }

            // Generate the symmetric security key using the secret key from configuration
            var key = new SymmetricSecurityKey(   
                Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));

            // Create signing credentials using the security key and specifying the hashing algorithm
            var credentials = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256);

            // Set the token's expiration time based on the current time and the duration specified in configuration
            var expireDate =
                DateTime.UtcNow.AddMinutes(
                    Convert.ToDouble(configuration["Jwt:DurationInMinutes"]));
            // Create the JWT token with the specified issuer, audience, claims, expiration time, and signing credentials
            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: claims,
                expires: expireDate,
                signingCredentials: credentials
            );

            var tokenHandler = new JwtSecurityTokenHandler();

            // Return the generated token along with its expiration time, user name, role, and permissions in an AuthResponseDto object
            return new AuthResponseDto
            {
                Token = tokenHandler.WriteToken(token),
                ExpireAt = expireDate,
                UserName = employee.User_Name,
                Role = employee.Role.Name,
                Permissions = permissions
            };
        }
    }
}
