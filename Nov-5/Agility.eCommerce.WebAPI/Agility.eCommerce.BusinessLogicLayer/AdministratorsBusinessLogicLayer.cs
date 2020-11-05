using System;
using System.Collections.Generic;
using System.Linq;
using Agility.eCommerce.DataLayer;

namespace Agility.eCommerce.BusinessLogicLayer
{
    public class AdministratorsBusinessLogicLayer
    {
        /// <summary>
        /// Gets the matching administrator from "Administrators" table where the specified username and password is matching.
        /// </summary>
        /// <param name="Username">Username to check</param>
        /// <param name="Password">Password to check</param>
        /// <returns>Returns matching administrator or returns null</returns>
        public Administrator GetAdministratorByUserNameAndPassword(string Username, string Password)
        {
            if (string.IsNullOrEmpty(Username) == false && string.IsNullOrEmpty(Password) == false)
            {
                //create object of AdministratorsDataLayer
                IAdministratorsDataLayer administratorsDataLayer = new AdministratorsDataLayer();

                //call the method
                Administrator admin = administratorsDataLayer.GetAdministratorByUserNameAndPassword(Username, Password);

                return admin; //return to web api
            }
            else
            {
                return null;
            }
        }
    }
}
