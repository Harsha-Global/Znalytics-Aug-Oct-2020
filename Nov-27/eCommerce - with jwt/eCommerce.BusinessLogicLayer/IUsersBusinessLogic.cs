using eCommerce.DataAccessLayer;
using eCommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BusinessLogicLayer
{
    public interface IUsersBusinessLogic
    {
        User GetUserByEmailAndPassword(LoginViewModel loginViewModel);
    }
}

