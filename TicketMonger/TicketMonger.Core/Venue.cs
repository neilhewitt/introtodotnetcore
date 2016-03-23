using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMonger.Core
{
    public class Venue
    {
        private static IList<Venue> _allVenues;
        private static object _padlock = new object();

        public static IEnumerable<Venue> AllVenues
        {
            get
            {
                if (_allVenues == null)
                {
                    lock (_padlock)
                    {
                        if (_allVenues == null)
                        {
                            List<Venue> venues = new List<Venue>();
                            venues.Add(new Venue(
                                "Park Lane Hotel",
                                new Address(
                                    "Park Lane Hotel", "142", "Park Lane", "", "London", "", "W1A QQ2", "UK"
                                    ),
                                "The Park Lane Hotel is a very nice hotel for conferences and other events.",
                                "555-1212",
                                "events@parklanehotel.fake",
                                "www.parklanehotel.fake",
                                "@parklanehotelfake"
                                ));

                            venues.Add(new Venue(
                                "National Motorcycle Museam",
                                new Address(
                                    "Midlands Motor Museum", "", "", "Coleshill", "Birmingham", "", "B2 2JP", "UK"
                                    ),
                                "The National Motorcycle Museum is an ideal place for automotive events.",
                                "555-1212",
                                "events@nmm.fake",
                                "www.nmm.fake",
                                "@nmmfake"
                                ));

                            _allVenues = venues;
                        }
                    }
                }

                return _allVenues;
            }
        }
        
        public string Name { get; }
        public Address Address { get; }
        public string Description { get; }
        public string ContactTelephone { get; }
        public string ContactEmail { get; }
        public string URL { get; }
        public string Twitter { get; }

        public Venue(string name, Address address, string description, string contactTelephone, string contactEmail, string url, string twitter)
        {
            Name = name;
            Address = address;
            Description = description;
            ContactTelephone = contactTelephone;
            ContactEmail = contactEmail;
            URL = url;
            Twitter = twitter;
        }
    }
}
