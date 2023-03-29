using NencyKitchen.DataModel.Authentication;
using NencyKitchen.DataModel.Persistance;
using NencyKitchen.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserService _userService;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserService userService)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userService = userService;
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            //Check if user already exists.
            if (_userService.GetUserByEmail(email) is not null)
            {
                throw new Exception("Korisnik sa ovim email-om vec postoji");
            }


            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            _userService.Add(user);

            Guid userId = Guid.NewGuid();

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token);
        }
        public AuthenticationResult Login(string email, string password)
        {
            if (_userService.GetUserByEmail(email) is not User user)
            {
                throw new Exception("Korisnik sa ovim email-om vec postoji");
            }

            if (user.Password != password)
            {
                throw new Exception("Pogresna lozinka");
            }

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token);
        }
    }
}
