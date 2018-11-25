using System;
using System.Collections.Generic;
using System.Text;
using pentry.domain;

namespace pentry.application
{
    public class RoomFacade : IRoomFacade
    {
        public Room Get(Guid id)
        {
            return new Room { Name = "Küche" };
        }

        public IEnumerable<Room> GetAll()
        {
            return new[] { new Room { Name = "Küche" } };
        }
    }
}
