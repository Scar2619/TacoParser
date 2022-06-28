namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        // <summary> Parses the provided line to create a TacoBell Location. </summary>
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            double lat = 0;

            if (double.TryParse(cells[0], out lat) == false)
            {
                logger.LogError($"{cells[0]} Bad data. Wasn't able to parse latitude as double.");
            }

            // grab the longitude from your array at index 1
            double longitude = 0;

            if (double.TryParse(cells[1], out longitude) == false)
            {
                logger.LogError("Bad data. Wasn't able to parse longitude as double.");
            }
            // grab the name from your array at index 2
            var name = cells[2];

            if (cells[2] == null || cells[2].Length == 0)
            {
                logger.LogError("No location name found while parsing.");
            }

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var point = new Point()
            {
                Latitude = lat,
                Longitude = longitude
            };


            var tacoBell = new TacoBell();

            tacoBell.Location = point;
            tacoBell.Name = name;

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return tacoBell;
        }

    }
}