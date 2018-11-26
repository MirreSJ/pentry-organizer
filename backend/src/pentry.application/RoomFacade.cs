using pentry.domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace pentry.application
{
    public class RoomFacade : IRoomFacade
    {
        private IEnumerable<Room> _rooms;

        public RoomFacade()
        {
            _rooms = new[] 
            {
                new Room
                {
                    Id = Guid.NewGuid(),
                    Name = "Küche",
                    Storages = new []
                    {
                        new Storage
                        {
                            Id = Guid.NewGuid(),
                            Name="Schrank neben Herd",
                            Description="Schrank zwischen Herd und Kühlschrank unten.",
                            Items = new []
                            {
                                new WeightedItem
                                {
                                    Id = Guid.NewGuid(),
                                    Name="Zucker",
                                    Original=1000,
                                    Current=180
                                }
                            }
                        }
                    }
                }
            };
        }

        public Room Get(Guid id)
        {
            return _rooms.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Room> GetAll()
        {
            return _rooms;
        }
    }
}
