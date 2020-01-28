using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Jefferson's Awesome Weather Calculator"); //Displays some text

            Console.WriteLine("Enter temperature in degrees fahrenheit"); //Displays some text

            int Temperature = int.Parse(Console.ReadLine()); //Takes user's input integer for temperature

            Console.WriteLine("Enter relative humidity"); //Displays some text

            int RelativeHumidity = int.Parse(Console.ReadLine()); //Takes user's input integer for relative humidity

            double DewPoint = Temperature - (9 * (100 - RelativeHumidity)) / 25; //Calculates DewPoint

            Console.WriteLine("The Dew Point is" + DewPoint); //Displays some text for Dew Point

            Console.WriteLine("Enter the wind speed (mph)"); //Displays some text

            double Windspeed = double.Parse(Console.ReadLine()); //Takes users's integer for wind speed

            double WindChill = 35.74 + (0.6215 * Temperature) - (35.75 * Math.Pow(Windspeed, 0.16)) + 
                (0.4275 * Temperature * Math.Pow(Windspeed, 0.16)); //Calculates Windchill 

            Console.WriteLine("The Wind Chill is" + WindChill); //Displays the final wind chill
          
        }
    }
}
