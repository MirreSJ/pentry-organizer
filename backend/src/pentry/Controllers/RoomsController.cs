using Microsoft.AspNetCore.Mvc;
using pentry.application;
using System;
using System.Linq;

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
            return Ok(_facade.GetAll().Select(r => new { r.Id, r.Name }));
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var room = _facade.Get(id);
            if (room == null)
            {
                return NotFound();
            }

            return Ok(new { room.Id, room.Name });
        }

        // GET: api/Rooms/5/Storages
        [HttpGet("{id}/storages")]
        public IActionResult GetStorages(Guid id)
        {
            var room = _facade.Get(id);
            if (room == null)
            {
                return NotFound();
            }

            return Ok(room.Storages.Select(s => new { s.Id, s.Name, s.Description }));
        }

        // GET: api/Rooms/5/Storages/9
        [HttpGet("{roomId}/storages/{storageId}")]
        public IActionResult GetStorage(Guid roomId, Guid storageId)
        {
            var room = _facade.Get(roomId);
            if (room == null)
            {
                return NotFound();
            }

            var storage = room.Storages.FirstOrDefault(s => s.Id == storageId);
            if (storage == null)
            {
                return NotFound();
            }

            return Ok(new { storage.Id, storage.Name, storage.Description });
        }

        // GET: api/Rooms/5/Storages/9/Items
        [HttpGet("{roomId}/storages/{storageId}/Items")]
        public IActionResult GetItems(Guid roomId, Guid storageId)
        {
            var room = _facade.Get(roomId);
            if (room == null)
            {
                return NotFound();
            }

            var storage = room.Storages.FirstOrDefault(s => s.Id == storageId);
            if (storage == null)
            {
                return NotFound();
            }

            return Ok(storage.Items.Select(i => new { i.Id, i.Name }));
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
