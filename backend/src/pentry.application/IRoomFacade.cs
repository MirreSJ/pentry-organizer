using pentry.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace pentry.application
{
    public interface IRoomFacade
    {
        IEnumerable<Room> GetAll();
        Room Get(Guid id);
    }
}
