using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webapi.Model;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _service;

        public PersonController(IPersonService service)
        {
            this._service = service;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            Debug.WriteLine("PersonCalled");
            return _service.GetPersons();
        }

        // POST api/values
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Person data)
        {
            if (_service.AddPerson(data.Name, data.Age))
                return Ok();
            return StatusCode(500);
        }
    }
}
