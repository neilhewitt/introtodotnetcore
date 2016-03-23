using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMonger.Core;

namespace TicketMonger.Site
{
    public class HomeViewModel
    {
        public IEnumerable<Event> TopEvents => Event.AllEvents.Take(4);
   
    }
}
