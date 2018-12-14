﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Course.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Course.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private StoreService service;

        private UserManager<IdentityUser> user;

        public StoreController(StoreService services, UserManager<IdentityUser> user)
        {
            this.service = services;
            this.user = user;
        }

        [HttpPost]
        [Route("/api/store")]
        public IActionResult ToOrder([FromBody] Article article)
        {
            var currentUser = user.FindByNameAsync(User.Identity.Name);
            return Ok(service.ToOrder(article.article, currentUser.Result.Id));
        }

        [HttpGet]
        [Route("/api/corb")]
        public IActionResult GetCorbUser()
        {
            var currentUser = user.FindByNameAsync(User.Identity.Name);
            return Ok(service.GetKorzina(currentUser.Result.Id));

        }

        [HttpPost]
        [Route("/api/corb/delete")]
        public IActionResult DeleteInCorbs([FromBody]SpareId spareId)
        {
            return Ok(service.DeleteInCorb(spareId.spareId));
        }

        [HttpPut]
        [Route("/api/corb/buy")]
        public IActionResult Buy()
        {
            var currentUser = user.FindByNameAsync(User.Identity.Name);
            return Ok(service.Buy(currentUser.Result.Id));
        }


    }
}