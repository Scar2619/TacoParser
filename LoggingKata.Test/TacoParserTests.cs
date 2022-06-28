using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.556383,-86.889051,Taco Bell Birmingha...", -86.889051)]
        [InlineData("32.484926,-84.935962,Taco Bell Columbus...", -84.935962)]
        [InlineData("33.785605,-85.770014,Taco Bell Jacksonville...", -85.770014)]
        [InlineData("30.157708,-85.591198,Taco Bell Panama Cit...", -85.591198)]
        [InlineData("30.486758,-84.315552,Taco Bell Tallahassee...", -84.315552)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var parser = new TacoParser();

            //Act
            var actual = parser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.556383,-86.889051,Taco Bell Birmingha...", 33.556383)]
        [InlineData("32.484926,-84.935962,Taco Bell Columbus...", 32.484926)]
        [InlineData("33.785605,-85.770014,Taco Bell Jacksonville...", 33.785605)]
        [InlineData("30.157708,-85.591198,Taco Bell Panama Cit...", 30.157708)]
        [InlineData("30.486758,-84.315552,Taco Bell Tallahassee...", 30.486758)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var parser = new TacoParser();

            //Act
            var actual = parser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
