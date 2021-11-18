using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertWeight
{
    public class Weight
    {
        public static double KilometersToMiles(double Kilometers)
        {
            return Math.Round((Kilometers / 1.609344), 4, MidpointRounding.AwayFromZero);
        }

        public static double MilesToKilometers(double Miles)
        {
            return Math.Round((1.609344 * Miles), 4, MidpointRounding.AwayFromZero);
        }

        public static double FootsToMeters(double Foot)
        {
            return Math.Round((Foot / 3.2808398950131), 4, MidpointRounding.AwayFromZero);
        }

        public static double MetersToFoots(double Meters)
        {
            return Math.Round((3.2808398950131 * Meters), 4, MidpointRounding.AwayFromZero);
        }

        public static double FootsToKilometers(double Foot)
        {
            return Math.Round((Foot / 3280.8398950131), 4, MidpointRounding.AwayFromZero);
        }

        public static double KilometersToFoots(double Kilometers)
        {
            return Math.Round((3280.8398950131 * Kilometers), 4, MidpointRounding.AwayFromZero);
        }

        public static double MilesToFoots(double Miles)
        {
            return Math.Round((5280 * Miles), 4, MidpointRounding.AwayFromZero);
        }

        public static double FootsToMiles(double Foot)
        {
            return Math.Round((Foot / 5280), 4, MidpointRounding.AwayFromZero);
        }

        public static double KilometersToMeters(double Kilometers)
        {
            return Math.Round((Kilometers * 1000), 4, MidpointRounding.AwayFromZero);
        }

        public static double MetersToKilometers(double Meters)
        {
            return Math.Round((Meters / 1000), 4, MidpointRounding.AwayFromZero);
        }

        public static double MilesToMeters(double Miles)
        {
            return Math.Round((1609.344 * Miles), 4, MidpointRounding.AwayFromZero);
        }

        public static double MetersToMiles(double Meters)
        {
            return Math.Round((Meters / 1609.344), 4, MidpointRounding.AwayFromZero);
        }

    }
}
