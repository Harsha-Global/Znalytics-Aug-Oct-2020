using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerce.WebAPI.ViewModels
{
    public class CustomerViewModel
    {
        public Guid CustomerID { get; set; }
        public string CustomerName { get; set; }
    }
}

