using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TitheEnvelopeApi
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _realm;

        public AuthenticationMiddleware(RequestDelegate next, string realm)
        {
            _next = next;
            _realm = realm;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                string authHeader = context.Request.Headers["Authorization"];
                if (authHeader != null && authHeader.StartsWith("Basic ",StringComparison.OrdinalIgnoreCase))
                {
                    var token = authHeader.Substring("Basic ".Length).Trim();

                    var encodedUsernameAndPassword = Encoding.UTF8.GetString(Convert.FromBase64String(token));

                    var username = encodedUsernameAndPassword.Split(':')[0];

                    var password = encodedUsernameAndPassword.Split(':')[1];

                    string userRole;

                    if (isAuthorized(username,password, out userRole))
                    {
                        var claims = new[] { new Claim("", username), new Claim(ClaimTypes.Role, userRole) };
                        var identity = new ClaimsIdentity(claims, "Basic");
                        context.User = new ClaimsPrincipal(identity);
                    }
                    else
                    {
                        context.Response.StatusCode = 401;
                        context.Response.Headers["WWW-Authenticate"] = "Basic realm=\"TitheEnvelope.com\"";
                    }
                }
            }
            catch (Exception)
            {

                context.Response.StatusCode = 201;
            }
            await _next(context);
        }

        public bool isAuthorized(string username, string password,out string userRole)
        {
            userRole = "Admin";
            return true;
        }
    }
}
