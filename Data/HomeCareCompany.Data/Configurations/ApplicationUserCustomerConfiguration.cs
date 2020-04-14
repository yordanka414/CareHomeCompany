namespace HomeCareCompany.Data.Configurations
{
    using HomeCareCompany.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ApplicationUserCustomerConfiguration : IEntityTypeConfiguration<ApplicationUserCustomer>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserCustomer> builder)
        {
            builder.HasKey(sc => new { sc.ApplicationUserId, sc.CustomerId });
        }
    }
}
