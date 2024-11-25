using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureOrangeEngine
{
    public class TemperatureProperties
    {
        public double TemperatureKelvinMeltPoint { get; set; } 
        public double TemperatureKelvinHalfCapacityPoint { get; set; }
        public TemperatureProperties(double tempuratureMeltPoint, double temperatureKelvinHalfCapacityPoint) {
            TemperatureKelvinMeltPoint = tempuratureMeltPoint;
            TemperatureKelvinHalfCapacityPoint = temperatureKelvinHalfCapacityPoint;
        }
        
    }
}
