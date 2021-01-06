//copyright (c) FuchsFarbe
//author: Myriam B.

using System;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

/* ============================================
*                   WeatherGenerator
* --------------------------------------------
*       This is for generating random weather 
*       conditions according to the climate of 
*       the region of the world map.
*  ===========================================
*/

namespace Tales_Of_Enariel
{
    public class WeatherGenerator : MonoBehaviour
    {
        public Text WeatherText;

        private Weather weather;

        private const double WEATHER_CHANGE_INTERVAL = 0.5;
        private Climate climate = new Climate();
        private Random rnd = new Random();

        private void Start()
        {
            climate = Climate.GetDefaultClimate();
            weather = new Weather();
            GenerateRandomDayDuration();
            GenerateRandomWeather();
            WeatherText.text = weather.ToString();
            var timerWeatherChange = new System.Threading.Timer(
                e => GenerateRandomWeather(),
                null,
                TimeSpan.Zero,
                TimeSpan.FromMinutes(WEATHER_CHANGE_INTERVAL));
            var timerDayDurationChange = new System.Threading.Timer(
                e => GenerateRandomDayDuration(),
                null,
                TimeSpan.Zero,
                TimeSpan.FromMinutes(1440));
        }

        // Update is called once per frame
        void Update()
        {
            WeatherText.text = weather.ToString();
        }

        void GenerateRandomWeather()
        {
            weather.Temperature = rnd.Next(climate.TemperatureRange.Minimum, climate.TemperatureRange.Maximum);
            weather.WindSpeed = rnd.Next(climate.WindSpeedRange.Minimum, climate.WindSpeedRange.Maximum);
            Array weatherTypeValues = Enum.GetValues(typeof(WeatherType));
            if(weather.Temperature >= 0)
            {
                weather.WeatherType = (WeatherType)rnd.Next(0, (int)WeatherType.Foggy);
            } else
            {
                weather.WeatherType = (WeatherType)rnd.Next(weatherTypeValues.Length);
            }
        }

        void GenerateRandomDayDuration()
        {
            weather.Sunrise = TimeSpan.FromSeconds(rnd.Next(Convert.ToInt32(climate.Sunrise.Minimum.TotalSeconds), Convert.ToInt32(climate.Sunrise.Maximum.TotalSeconds)));
            weather.Sunset = TimeSpan.FromSeconds(rnd.Next(Convert.ToInt32(climate.Sunset.Minimum.TotalSeconds), Convert.ToInt32(climate.Sunset.Maximum.TotalSeconds)));
        }
    }
}