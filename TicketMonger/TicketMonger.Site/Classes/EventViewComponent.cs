using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMonger.Core;

namespace TicketMonger.Site.Classes
{
    [ViewComponent(Name = "Event")]
    public class EventViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Event @event)
        {
            return View(@event);
        }
    }
}
