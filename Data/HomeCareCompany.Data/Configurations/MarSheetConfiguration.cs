namespace HomeCareCompany.Data.Configurations
{
    using HomeCareCompany.Data.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MarSheetConfiguration : IEntityTypeConfiguration<Marsheet>
    {
        public void Configure(EntityTypeBuilder<Marsheet> builder)
        {
            builder.HasKey(sc => new { sc.CustomerId, sc.MedicationId });
        }
    }
}
