using System;
using System.Collections.Generic;

namespace pentry.domain
{
    public class Storage
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<IItem> Items { get; set; }
    }
}
