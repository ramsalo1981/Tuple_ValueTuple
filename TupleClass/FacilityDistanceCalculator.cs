using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleClass
{
    public static class FacilityDistanceCalculator
    {
        private static Random random = new Random();
        public static Tuple<string, string> CalculateFacilityDistance(string facilityName)
        {
            return Tuple.Create(facilityName, ($"{(random.NextDouble() * 10.0).ToString("F2")} km"));
        }
        public static Tuple<string, string> CalculateFacilityDistanceV2(string facilityName)
        {
            return new Tuple<string, string>(facilityName, ($"{(random.NextDouble() * 10.0).ToString("F2")} km"));
        }

        public static Tuple<string, double> CalculateFacilityDistanceV3(string facilityName)
        {
            return Tuple.Create(facilityName, random.NextDouble() * 10.0);
        }
    }
}
