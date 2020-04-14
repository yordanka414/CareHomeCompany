// ReSharper disable VirtualMemberCallInConstructor
namespace HomeCareCompany.Data.Models
{
    using HomeCareCompany.Data.Common.Models;

    public class Address : BaseDeletableModel<int>
    {
        public string Country { get; set; }

        public string Town { get; set; }

        public string Street { get; set; }

        public string PostCode { get; set; }
    }
}
