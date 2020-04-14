namespace HomeCareCompany.Data.Models
{
    using HomeCareCompany.Data.Common.Models;
    using System.Collections.Generic;

    public class Medication : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int Dose { get; set; }

        public string Form { get; set; }

        public bool LongTermMedication { get; set; }

        public string Instructions { get; set; }

        public ICollection<Marsheet> Marsheets { get; set; }
    }
}
