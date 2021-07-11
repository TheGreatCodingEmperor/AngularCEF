using System;
using Microsoft.AspNetCore.Mvc;

namespace AngularCEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "hello world";
        }

        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            return Ok(id);
        }
    }
}