namespace HomeCareCompany.Data.Models
{
    using System;

    using HomeCareCompany.Data.Common.Models;

    public class Marsheet : IDeletableEntity, IAuditInfo
    {
        public int MedicationId { get; set; }

        public Medication Medication { get; set; }

        public int CustomerId
        { get; set; }

        public Customer Customer { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
