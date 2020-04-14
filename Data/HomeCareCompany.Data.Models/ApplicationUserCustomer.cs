using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCareCompany.Data.Models
{
    public class ApplicationUserCustomer
    {
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
