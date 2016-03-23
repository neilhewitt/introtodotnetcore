namespace TicketMonger.Core
{
    public class Address
    {
        public string BuildingName { get; }
        public string BuildingNumber { get; }
        public string StreetAddress { get; }
        public string AddressLine2 { get; }
        public string TownOrCity { get; }
        public string County { get; }
        public string Postcode { get; }
        public string Country { get; }

        public Address(string buildingName, string buildingNumber, string streetAddress, string addressLine2, string townOrCity, string county, string postcode, string country)
        {
            BuildingName = buildingName;
            BuildingNumber = buildingNumber;
            StreetAddress = streetAddress;
            AddressLine2 = addressLine2;
            TownOrCity = townOrCity;
            County = county;
            Postcode = postcode;
            Country = Country;
        }
    }
}