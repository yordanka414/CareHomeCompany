namespace HomeCareCompany.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using HomeCareCompany.Common;
    using HomeCareCompany.Data.Models;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    internal class RolesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

            await SeedRoleAsync(roleManager, GlobalConstants.AdministratorRoleName);
            await SeedRoleAsync(roleManager, GlobalConstants.LiveInCarer);
            await SeedRoleAsync(roleManager, GlobalConstants.HourlyCarer);
            await SeedRoleAsync(roleManager, GlobalConstants.AssistentManager);
            await SeedRoleAsync(roleManager, GlobalConstants.Manager);
            await SeedRoleAsync(roleManager, GlobalConstants.Customer);

        }

        private static async Task SeedRoleAsync(RoleManager<ApplicationRole> roleManager, string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                var result = await roleManager.CreateAsync(new ApplicationRole(roleName));
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
