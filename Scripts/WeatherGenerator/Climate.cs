//copyright (c) FuchsFarbe
//author: Myriam B.

using System;

/* ============================================
*                   Climate
* --------------------------------------------
*       This is for defining the climate 
*       for a region of the world map.
*  ===========================================
*/

namespace Tales_Of_Enariel
{
    public class Climate
    {
        public Range<int> TemperatureRange = new Range<int>();
        public Range<int> WindSpeedRange = new Range<int>();
        public Range<TimeSpan> Sunrise = new Range<TimeSpan>();
        public Range<TimeSpan> Sunset = new Range<TimeSpan>();

        public Climate() { }

        public static Climate GetDefaultClimate()
        {
            Climate climate = new Climate();
            climate.TemperatureRange.Minimum = -10;
            climate.TemperatureRange.Maximum = 35;
            climate.WindSpeedRange.Minimum = 0;
            climate.WindSpeedRange.Maximum = 150;
            climate.Sunrise.Minimum = new TimeSpan(5, 30, 0);
            climate.Sunrise.Maximum = new TimeSpan(8, 0, 0);
            climate.Sunset.Minimum = new TimeSpan(16, 30, 0);
            climate.Sunset.Maximum = new TimeSpan(21, 0, 0);

            return climate;
        }
    }
}