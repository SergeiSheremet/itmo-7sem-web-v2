using Microsoft.AspNetCore.Mvc;
using RestProject.Services;
using System.Collections.Generic;

namespace RestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        private readonly IValueService _service;

        public ValueController(IValueService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IDictionary<string, object>> Get() => Ok(_service.Get());

        [HttpPost]
        public ActionResult Post([FromBody] IDictionary<string, object> value) => ToResponseCode(_service.Post(value));

        [HttpPut]
        public ActionResult Put([FromBody] IDictionary<string, object> value) => ToResponseCode(_service.Put(value));

        [HttpPatch]
        public ActionResult Patch([FromBody] IDictionary<string, object> value) => ToResponseCode(_service.Patch(value));

        private ActionResult ToResponseCode(bool value) => value ? Ok("ok") : BadRequest();
    }
}
