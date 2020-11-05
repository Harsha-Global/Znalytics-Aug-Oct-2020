using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Agility.eCommerce.BusinessLogicLayer;
using Agility.eCommerce.DataLayer;
using Agility.eCommerce.WebAPI.Models;

namespace Agility.eCommerce.WebAPI.Controllers
{
    public class AdministratorsController : ApiController
    {
        [HttpPost]
        [Route("api/administrators/login")]
        //http://localhost:50305/api/administrators/login
        public Administrator Post(LoginViewModel loginViewModel)
        {
            //create object of AdministratorsBusinessLogicLayer
            AdministratorsBusinessLogicLayer administratorsBusinessLogicLayer = new AdministratorsBusinessLogicLayer();

            //call the method
            Administrator admin = administratorsBusinessLogicLayer.GetAdministratorByUserNameAndPassword(loginViewModel.Username, loginViewModel.Password);

            //send response to browser
            return admin;
        }
    }
}

