using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace demo_API.Models
{
    public class Main
    {
        public int MainID { get; set; }
        public double CurrentTemperature { get; set; }
        public double MinimumTemperature { get; set; }
        public double MaximumTemperature { get; set; }
        public int Humidity { get; set; }
        public int AirPressure { get; set; }

    }
}