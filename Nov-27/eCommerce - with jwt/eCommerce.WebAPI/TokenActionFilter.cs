using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//add following
using System.Web.Http.Filters;
using System.Web.Http.Controllers;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace eCommerce.WebAPI
{
    public class TokenActionFilter : ActionFilterAttribute
    {
        //executes after the action method
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //check if the user is valid or not
            if (actionExecutedContext.Request.Properties["Userid"] != null)
            {
                //get details from request.properties which were added by the action method
                object Userid = actionExecutedContext.Request.Properties["Userid"];
                object Timestamp = actionExecutedContext.Request.Properties["Timestamp"];

                //generate token
                string tk = GetToken(Userid, Timestamp);

                //add token to response header
                actionExecutedContext.Response.Headers.Add("token", tk);
                actionExecutedContext.Response.Headers.Add("Access-Control-Expose-Headers", "*");
            }
        }

        public string GetToken(object Userid, object Timestamp)
        {
            //domain of the current app (can be dummy, for example)
            string issuer = "http://www.mysite.com";

            //app level secret
            string secret = "my_secret_key_1234";

            //string convert into byte[]
            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secret));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            //Create claims (for payload)
            var claims = new List<Claim>() {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("valid", "1"),
                new Claim("Userid", Convert.ToString(Userid)),
                new Claim("ts", Convert.ToString(Timestamp))
            };

            //generate actual token
            JwtSecurityToken token = new JwtSecurityToken(issuer, issuer, claims, expires: DateTime.Now.AddDays(1), signingCredentials: credentials);
            string jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

            return jwtToken;
        }
    }
}

