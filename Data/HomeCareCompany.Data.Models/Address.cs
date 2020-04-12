// ReSharper disable VirtualMemberCallInConstructor
using HomeCareCompany.Data.Common.Models;

namespace HomeCareCompany.Data.Models
{
    public class Address : BaseDeletableModel<int>
    {
        public string Country { get; set; }

        public string Town { get; set; }

        public string Street { get; set; }

        public string PostCode { get; set; }
    }
}
