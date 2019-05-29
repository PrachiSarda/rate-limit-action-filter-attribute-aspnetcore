using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimonGilbert.Blog.Attributes;
using SimonGilbert.Blog.Models;

namespace SimonGilbert.Blog.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        [HttpPost]
        [RequestRateLimit(Name = "Limit Request Number", Seconds = 5)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get([FromBody]GetRequest getRequest)
        {
            return Ok();
        }
    }
}


