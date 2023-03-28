using NencyKitchen.DataModel.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.Services.Interfaces
{
    public interface IUserService
    {
        User? GetUserByEmail(string email);
        void Add(User user);
    }
}
