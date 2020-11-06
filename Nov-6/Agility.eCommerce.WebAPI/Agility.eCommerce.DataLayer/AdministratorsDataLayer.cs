using System;
using System.Collections.Generic;
using System.Linq;

namespace Agility.eCommerce.DataLayer
{
    public class AdministratorsDataLayer: DataLayerBase<Administrator>, IAdministratorsDataLayer
    {
        public Administrator GetAdministratorByUserNameAndPassword(string Username, string Password)
        {
            eCommerceEntities db = new eCommerceEntities();

            //Get single administrator where username and password matches
            Administrator admin = db.Administrators
                .SingleOrDefault(temp => temp.Username == Username && temp.Password == Password); //SELECT * FROM Administrators WHERE Username=@Username AND Password=@Password

            return base.CheckNullAndReturn(admin);
        }
    }
}
