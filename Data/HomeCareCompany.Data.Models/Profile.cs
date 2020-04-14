namespace HomeCareCompany.Data.Models
{
    using System;
    using System.Collections.Generic;

    using HomeCareCompany.Data.Common.Models;

    public class Profile : BaseDeletableModel<int>
    {
        public DateTime DateOfBirth { get; set; }

        public int Age => this.CalculateAge(this.DateOfBirth, DateTime.UtcNow);

        public int FullNameId
        { get; set; }

        public FullName FullName { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }

        private int CalculateAge(DateTime dateOfBirth, DateTime utcNow)
        {
            int age = utcNow.Year - dateOfBirth.Year;

            if (utcNow < dateOfBirth.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
