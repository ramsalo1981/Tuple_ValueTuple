using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMultipleValues
{
    public class Location
    {
        public string? Name { get; set; }
        public double DistanceInKm { get; set; }

        public override string ToString()
        {
            return $"{Name} ....... {DistanceInKm.ToString("F2")} km";
        }
    }
}
