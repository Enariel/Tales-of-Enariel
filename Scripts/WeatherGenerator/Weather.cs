//copyright (c) FuchsFarbe
//author: Myriam B.

using System;

/* ============================================
*                   Weather
* --------------------------------------------
*       This is for defining the weather 
*       conditions.
*  ===========================================
*/

namespace Tales_Of_Enariel
{
    public class Weather
    {
        public int Temperature;
        public int WindSpeed;
        public WeatherType WeatherType;
        public TimeSpan Sunset;
        public TimeSpan Sunrise;

        public Weather() { }

        public static Weather GetDefaultWeather()
        {
            Weather weather = new Weather();
            weather.Temperature = 25;
            weather.WindSpeed = 10;
            weather.WeatherType = WeatherType.Sunny;
            weather.Sunrise = new TimeSpan(7, 0, 0);
            weather.Sunset = new TimeSpan(17, 30, 0);

            return weather;
        }

        public override string ToString()
        {
            return $"{WeatherType}\r\n" +
                $"Temperature: {Temperature}°C\r\n" +
                $"Wind Speed: {WindSpeed} km/h\r\n" +
                $"Sunset: {Sunrise}\r\n" +
                $"Sunrise: {Sunset}";
        }
    }
}