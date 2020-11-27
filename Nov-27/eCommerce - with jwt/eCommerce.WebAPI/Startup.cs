using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
//add following
using Microsoft.Owin.Security.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

[assembly: OwinStartup(typeof(eCommerce.WebAPI.Startup))]

namespace eCommerce.WebAPI
{
    public class Startup
    {
        //Executes once - when the app runs for the first time
        public void Configuration(IAppBuilder app)
        {
            app.UseJwtBearerAuthentication(
                new JwtBearerAuthenticationOptions() { 
                    AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Active,
                    TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidIssuer = "http://www.mysite.com",
                        ValidateAudience = true,
                        ValidAudience = "http://www.mysite.com",
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("my_secret_key_1234"))
                    }
            });
        }
    }
}


