using System;
using System.Collections.Generic;
using System.Text;

namespace pentry.domain
{
    public class Item : IItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
