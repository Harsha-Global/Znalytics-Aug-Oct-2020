using eCommerce.BusinessLogicLayer;
using eCommerce.DataAccessLayer;
using eCommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace eCommerce.WebAPI.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    public class AccountController : ApiController
    {
        //private fields
        private IUsersBusinessLogic usersBusinessLogic;

        /// <summary>
        /// Constructor executes when an object is created for the CustomersController
        /// </summary>
        public AccountController(IUsersBusinessLogic business)
        {
            usersBusinessLogic = business;
        }

        [Route("api/Account/Login")]
        [TokenActionFilter]
        public User Post(LoginViewModel loginViewModel)
        {
            User user = this.usersBusinessLogic.GetUserByEmailAndPassword(loginViewModel);
            if (user != null)
            {
                //generate token
                Request.Properties.Add("Userid", user.UserID);
                //Request.Properties.Add("Username", user.FullName);
                Request.Properties.Add("Timestamp", ((Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds));
            }
            else
            {
                //don't generate

            }
            return user;
        }
    }
}

