using System;
namespace LoggingKata
{
    public class TacoBell : ITrackable
    {

        //TacoBell class implements an ITrackable Interface with Name and Location
        public string Name { get; set; }

        //Point is a struct that represents a GPS Location with Latitude and Longitude properties
        public Point Location { get; set; }


        // Constructor will create a TacoBell object with the provided Latitude, Longitude, and Name.
        public TacoBell(string name, Point location)
        {
            Name = name;
            Location = location;
        }

        public TacoBell()
        {
        }
    }
}

