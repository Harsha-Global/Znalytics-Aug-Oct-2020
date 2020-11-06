using System;
using System.Collections.Generic;
using System.Linq;

namespace Agility.eCommerce.DataLayer
{
    public interface IAdministratorsDataLayer
    {
        Administrator GetAdministratorByUserNameAndPassword(string Username, string Password);
    }
}
