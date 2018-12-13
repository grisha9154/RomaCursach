using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Course.Modeles;
using Course.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course.Controllers
{
    [Route("api/spares")]
    [ApiController]
    public class SpareController : ControllerBase
    {
        private SpareService service;
        public SpareController(SpareService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAllSpares()
        {
            return Ok(service.GetAllSpares());
        }

        [HttpGet]
        [Route("{article}")]
        public IActionResult GetSpareByArticle(int article)
        {
            return Ok(service.GetSpareByArticle(article));
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateSpare([FromBody]Spare spare)
        {
            return Ok(service.CreateSpare(spare));
        }

        [HttpPut]
        [Route("")]
        public IActionResult UpdateSpare([FromBody]Spare spare)
        {
            return Ok(service.UpdateSpare(spare));
        }

        [HttpDelete]
        [Route("{spareId}")]
        public IActionResult DeleteSpare(int spareId)
        {
            return Ok(service.DeleteSpare(spareId));
        }

        [HttpGet]
        [Route("search/{like}")]
        public IActionResult GetByDescription(string like)
        {
            return Ok(service.GetSpareByDescription(like));
        }

        [HttpGet]
        [Route("searchh/{typeId}")]
        public IActionResult GetSpareByType( int typeId)
        {
            return Ok(service.GetByType(typeId));
        }
    }
}