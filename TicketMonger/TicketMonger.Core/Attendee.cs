using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMonger.Core
{
    public class Attendee
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public Address Address { get; }
        public DateTime DateBooked { get; }
        public string SpecialRequirements { get; }

        public string FullName => $"{FirstName}{(String.IsNullOrWhiteSpace(MiddleName) ? "" : $" {MiddleName}")} {LastName}";

        public Attendee(string firstName, string middleName, string lastName, Address address, DateTime dateBooked, string specialRequirements = null)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Address = address;
            DateBooked = dateBooked;
            SpecialRequirements = specialRequirements;
        }
    }
}
