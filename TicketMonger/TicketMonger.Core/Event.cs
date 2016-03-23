using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMonger.Core
{
    public class Event
    {
        private static IList<Event> _allEvents;
        private static object _padlock = new object();

        public static IEnumerable<Event> AllEvents
        {
            get
            {
                if (_allEvents == null)
                {
                    lock (_padlock)
                    {
                        if (_allEvents == null)
                        {
                            List<Event> events = new List<Event>();
                            events.Add(new Event(
                                "TechSprint 2016",
                                "A Euromoney hackathon. With James Counter organising, this will run as smooth as butter.",
                                DateTime.Parse("01/11/16"), 
                                DateTime.Parse("03/11/16"), 
                                Venue.AllVenues.SingleOrDefault(v => v.Name == "Park Lane Hotel"),
                                1000M
                                ));
                            events.Add(new Event(
                                "BUILD 2016",
                                "Microsoft's premier developer conference, held this year in San Fransisco, USA.",
                                DateTime.Parse("01/06/16"),
                                DateTime.Parse("03/06/16"),
                                Venue.AllVenues.SingleOrDefault(v => v.Name == "National Motorcycle Museum"),
                                1599.99M,
                                1400M
                                ));
                            events.Add(new Event(
                                 "Euromoney Digital Summit",
                                 "If you don't want to go to this, you're probably already dead.",
                                 DateTime.Parse("11/03/16"),
                                 DateTime.Parse("11/03/16"),
                                 Venue.AllVenues.SingleOrDefault(v => v.Name == "Park Lane Hotel"),
                                 1000M
                                 ));
                            events.Add(new Event(
                                 "David Whitney's Code Grotto",
                                 "David is the Bad Santa of the Code Dojo world. Come and see why.",
                                 DateTime.Parse("01/05/16"),
                                 DateTime.Parse("01/05/16"),
                                 Venue.AllVenues.SingleOrDefault(v => v.Name == "National Motorcycle Museum"),
                                 1000M
                                 ));

                            _allEvents = events;
                        }
                    }
                }

                return _allEvents;
            }
        }

        public string Name { get; }
        public string Description { get; }
        public DateTime Starts { get; }
        public DateTime Ends { get; }
        public Venue Venue { get; }
        public decimal Price { get; }
        public decimal? EarlyBirdPrice { get; }

        public void AddAttendee(Attendee attendee)
        {
            // do nothing yet, awaiting plumbing
        }
       
        public Event(string name, string description, DateTime starts, DateTime ends, Venue venue, decimal price, decimal? earlyBirdPrice = null)
        {
            Name = name;
            Starts = starts;
            Description = description;
            Ends = ends;
            Venue = venue;
            Price = price;
            EarlyBirdPrice = earlyBirdPrice;
        }
    }
}
