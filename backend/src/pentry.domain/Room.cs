using System;
using System.Collections.Generic;

namespace pentry.domain
{
    public class Room
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Storage> Storages { get; set; }
    }
}
