namespace HomeCareCompany.Data.Models
{
    using HomeCareCompany.Data.Common.Models;

    public class FullName : BaseDeletableModel<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
