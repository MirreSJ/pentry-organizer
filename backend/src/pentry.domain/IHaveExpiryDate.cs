using System;
using System.Collections.Generic;
using System.Text;

namespace pentry.domain
{
    interface IHaveExpiryDate
    {
        Date ExpiryDate { get; }
    }
}
