using System;
using System.Collections.Generic;
using System.Text;

namespace pentry.domain
{
    interface IHaveWeight
    {
        double Current { get; set; }
        double Original { get; set; }
        double Level { get; } 
    }
}
