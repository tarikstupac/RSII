using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using VGFeed.Model.Requests;
using VGFeed.WebAPI.Services;

namespace VGFeed.WebAPI.Security
{
    public class BasicAuthenticationOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScheme = "basic";
        public string Scheme => DefaultScheme;
        public string AuthenticationType = DefaultScheme;
    }
    public class BasicAuthenticationHandler : AuthenticationHandler<BasicAuthenticationOptions>
    {
        public const string BasicHeaderName = "Authorization";
        private readonly IKorisniciService _userService;
        public BasicAuthenticationHandler(
            IOptionsMonitor<BasicAuthenticationOptions> options, 
            ILoggerFactory logger, 
            UrlEncoder encoder, 
            ISystemClock clock,
            IKorisniciService userService) : base(options, logger, encoder, clock)
        {
            _userService = userService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey(BasicHeaderName))
                return AuthenticateResult.Fail("Missing Authorization Header");

            Model.Korisnici user = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers[BasicHeaderName]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = System.Text.Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                user = _userService.Authenticiraj(username, password);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (user == null)
            {
                return AuthenticateResult.Fail("Invalid Username or Password");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.KorisnikId.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Uloga.Naziv)
            };  

            var identity = new ClaimsIdentity(claims, Options.AuthenticationType);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Options.Scheme);

            return AuthenticateResult.Success(ticket);
        }
    }
}
