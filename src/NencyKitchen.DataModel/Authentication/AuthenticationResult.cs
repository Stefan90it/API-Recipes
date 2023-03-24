using NencyKitchen.DataModel.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.DataModel.Authentication
{
    public record AuthenticationResult(
        User User,
        string Token);
}
