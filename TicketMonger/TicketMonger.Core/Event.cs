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
                            //    List<Venue> venues = new List<Venue>();
                            //    venues.Add(new Venue(
                            //        "Park Lane Hotel",
                            //        new Address(
                            //            "Park Lane Hotel", "142", "Park Lane", "", "London", "", "W1A QQ2", "UK"
                            //            ),
                            //        "The Park Lane Hotel is a very nice hotel for conferences and other events.",
                            //        "555-1212",
                            //        "events@parklanehotel.fake",
                            //        "www.parklanehotel.fake",
                            //        "@parklanehotelfake"
                            //        ));

                            //    venues.Add(new Venue(
                            //        "National Motorcycle Museam",
                            //        new Address(
                            //            "Midlands Motor Museum", "", "", "Coleshill", "Birmingham", "", "B2 2JP", "UK"
                            //            ),
                            //        "The National Motorcycle Museum is an ideal place for automotive events.",
                            //        "555-1212",
                            //        "events@nmm.fake",
                            //        "www.nmm.fake",
                            //        "@nmmfake"
                            //        ));

                            //    _allVenues = venues;

                        }
                    }
                }

                return _allEvents;
            }
        }

        public string Name { get; }
        public DateTime Starts { get; }
        public DateTime Ends { get; }
        public Venue Venue { get; }
        public decimal Price { get; }
        public decimal? EarlyBirdPrice { get; }

        public void AddAttendee(Attendee attendee)
        {
            // do nothing yet, awaiting plumbing
        }
       
        public Event(string name, DateTime starts, DateTime ends, Venue venue, decimal price, decimal? earlyBirdPrice = null)
        {
            Name = name;
            Starts = starts;
            Ends = ends;
            Venue = venue;
            Price = price;
            EarlyBirdPrice = earlyBirdPrice;
        }
    }
}
