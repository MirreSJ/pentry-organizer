﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pentry.domain
{
    public interface IItem
    {
        Guid Id { get; }
        string Name { get; }
    }
}
