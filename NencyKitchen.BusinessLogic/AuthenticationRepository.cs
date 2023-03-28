using NencyKitchen.BusinessLogic.Interfaces;
using NencyKitchen.DataModel.Authentication;
using NencyKitchen.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.BusinessLogic
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationRepository(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        public AuthenticationResult Login(string email, string password)
        {
            return _authenticationService.Login(email, password);
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            return _authenticationService.Register(firstName, lastName, email, password);
        }
    }
}
