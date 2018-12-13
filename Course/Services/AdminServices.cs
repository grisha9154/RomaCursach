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

        //public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        //{
        //    returnUrl = returnUrl ?? Url.Content("~/");
        //    if (ModelState.IsValid)
        //    {
        //        var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
        //        var result = await _userManager.CreateAsync(user, Input.Password);
        //        if (result.Succeeded)
        //        {
        //            _logger.LogInformation("User created a new account with password.");

        //            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        //            var callbackUrl = Url.Page(
        //                "/Account/ConfirmEmail",
        //                pageHandler: null,
        //                values: new { userId = user.Id, code = code },
        //                protocol: Request.Scheme);

        //            await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
        //                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");


        //            await _userManager.AddToRoleAsync(user, "user");
        //            return LocalRedirect(returnUrl);
        //        }
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError(string.Empty, error.Description);
        //        }
        //    }

        public List<Corb> GetOrders()
        {
            return context.Corbs.ToList();
        }



        }
    }
