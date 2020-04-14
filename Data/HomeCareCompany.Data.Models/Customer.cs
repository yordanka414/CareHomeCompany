namespace HomeCareCompany.Data.Models
{
    using System.Collections.Generic;

    using HomeCareCompany.Data.Common.Models;

    public class Customer : BaseDeletableModel<int>
    {
        public int ProfileId { get; set; }

        public Profile Profile { get; set; }

        public virtual ICollection<Marsheet> Marsheets { get; set; }

        public virtual ICollection<ApplicationUserCustomer> ApplicationUserCustomers { get; set; }
    }
}
