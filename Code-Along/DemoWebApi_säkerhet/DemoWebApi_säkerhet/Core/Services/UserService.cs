using DemoWebApi_säkerhet.Core.Interfaces;
using DemoWebApi_säkerhet.Data.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DemoWebApi_säkerhet.Core.Services
{
    public class UserService : IUserService
    {
        public string GenerateToken(User user)
        {
            //Här lägger vi in att användaren har rollen Admin
            //Detta får man också från identity providern eller databasen
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Role, "Admin"));

            //Sätta upp kryptering. Samma säkerhetsnyckel som när vi satte upp tjänsten
            //Denna förvaras på ett säkert ställe tex Azure Keyvault eller liknande och hårdkodas
            //inte in på detta sätt                                         
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mykey1234567&%%485734579453%&//1255362"));

            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            //Skapa options för att sätta upp en token
            var tokenOptions = new JwtSecurityToken(
                    issuer: "http://localhost:5181",
                    audience: "http://localhost:5181",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(20),
                    signingCredentials: signinCredentials);

            //Generar en ny token som skall skickas tillbaka 
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return tokenString;


        }

        public bool Login(User user)
        {

            //Här görs i vanliga fall en slagning mot en identity provider
            //eller om applikationen hanterar användare själv via en databas
            if (user.UserName == "Lisa" && user.Password == "Test1234!")
                return true;
           
            return false;
        }
    }
}
