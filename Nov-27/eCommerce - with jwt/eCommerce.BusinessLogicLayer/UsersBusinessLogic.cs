using eCommerce.DataAccessLayer;
using eCommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BusinessLogicLayer
{
    public class UsersBusinessLogic : IUsersBusinessLogic
    {
        //private fields
        private IUsersDataAccess usersDataAccess;

        /// <summary>
        /// Constructor that executes when an object is created for the CustomersBusinessLogic class
        /// </summary>
        public UsersBusinessLogic(IUsersDataAccess usersDataAccess)
        {
            //initialize usersDataAccess
            this.usersDataAccess = usersDataAccess;
        }

        public User GetUserByEmailAndPassword(LoginViewModel loginViewModel)
        {
            //convet password into hash
            var crypt = new SHA256Managed();
            string passwordHash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(loginViewModel.Password));
            foreach (byte theByte in crypto)
            {
                passwordHash += theByte.ToString("x2");
            }

            User user = this.usersDataAccess.GetUserByEmailAndPassword(loginViewModel.Email, passwordHash);

            return user;
        }
    }
}
