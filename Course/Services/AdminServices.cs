using Course.Controllers.AdminControllers;
using Course.Data;
using Course.Modeles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Services
{
    public class AdminServices
    {
        private ApplicationDbContext context;

        private UserManager<IdentityUser> manager;

        public AdminServices(ApplicationDbContext context, UserManager<IdentityUser> manager)
        {
            this.context = context;
            this.manager = manager;

        }

        public List<IdentityUser> GetAllUsers()
        {
            return context.Users.ToList();
        }

        public async Task CreateManager(CreateManagerModel model)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email, EmailConfirmed = true };
            var result = await manager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await manager.AddToRoleAsync(user, "manager");
            }
        }
    }
}
