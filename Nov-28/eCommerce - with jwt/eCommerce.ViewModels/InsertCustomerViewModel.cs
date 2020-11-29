using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerce.WebAPI.ViewModels
{
    public class InsertCustomerViewModel
    {
        public string CustomerName { get; set; }
        public Nullable<DateTime> DateOfJoining { get; set; }
    }
}
