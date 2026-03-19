
using DemoWebApi_säkerhet.Core.Interfaces;
using DemoWebApi_säkerhet.Core.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddAuthentication(opt => {
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
   //Här säger vi hur vi skall jobba med JWT
   .AddJwtBearer(opt => {
       opt.TokenValidationParameters = new TokenValidationParameters
       {
           //Issuer är vem (vilken server) som utfärdat en JWT token
           ValidateIssuer = true,
           ValidateAudience = true,
           ValidateLifetime = true,
           ValidateIssuerSigningKey = true,
           ValidIssuer = "http://localhost:5181",
           ValidAudience = "http://localhost:5181",
           IssuerSigningKey =
      new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mykey1234567&%%485734579453%&//1255362"))
       };
   });

builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

//Här spelar det roll vilken ordning saker sätts upp. Routing måste vara före
//authentication och authorization
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints => {endpoints.MapControllers(); });



app.Run();
