using Microsoft.AspNetCore.Http;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IDictionary<string, object>> Get() => Ok(_service.Get());

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] IDictionary<string, object> value) => ToResponseCode(_service.Post(value));

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Put([FromBody] IDictionary<string, object> value) => ToResponseCode(_service.Put(value));

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Patch([FromBody] IDictionary<string, object> value) => ToResponseCode(_service.Patch(value));

        private ActionResult ToResponseCode(bool value) => value ? Ok("ok") : BadRequest();
    }
}
