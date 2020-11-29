using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DataAccessLayer
{
    public class UsersDataAccess : IUsersDataAccess
    {
        //private fields
        private eCommerceDbContext db;

        /// <summary>
        /// Constructor that executes when an object is created for CustomersDataLayer class
        /// </summary>
        public UsersDataAccess()
        {
            db = new eCommerceDbContext();
        }

        public User GetUserByEmailAndPassword(string email, string passwordHash)
        {
            User user = db.Users.Where(temp => temp.Email == email && temp.Password == passwordHash).FirstOrDefault();
            return user;
        }
    }
}
