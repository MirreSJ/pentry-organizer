using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pentry.application;

namespace pentry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("0.8")]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomFacade _facade;

        public RoomsController(IRoomFacade facade)
        {
            _facade = facade;
        }

        // GET: api/Rooms
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_facade.GetAll());
        }

        // GET: api/Rooms/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(Guid id)
        {
            return Ok(_facade.Get(id));
        }

        //// POST: api/Rooms
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Rooms/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
