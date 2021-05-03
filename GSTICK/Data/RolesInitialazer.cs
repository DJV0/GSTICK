using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Data
{
    public static class RolesInitialazer
    {
        public static async Task InitializeAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string managerEmail = "dejavucool97@gmail.com";
            string managerPassword = "Admin.97";
            string managerFirstName = "Олег";
            string managerLastName = "Терентьев";
            string managerPhone = "0965226624";

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("manager") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("manager"));
            }
            if (await roleManager.FindByNameAsync("customer") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("customer"));
            }
            if(await userManager.FindByEmailAsync(managerEmail) == null)
            {
                ApplicationUser admin = new ApplicationUser()
                {
                    Email = managerEmail,
                    FirstName = managerFirstName,
                    LastName = managerLastName,
                    PhoneNumber = managerPhone,
                    UserName = managerEmail,
                    EmailConfirmed = true
                };
                IdentityResult result = await userManager.CreateAsync(admin, managerPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "manager");
                }
            }
        }
    }
}
