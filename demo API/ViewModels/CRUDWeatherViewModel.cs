using demo_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo_API.ViewModels
{
    public class CRUDWeatherViewModel
    {
        public int WeatherID { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string CountryCode { get; set; }
        public double CurrentTemperature { get; set; }
        public double MinimumTemperature { get; set; }
        public double MaximumTemperature { get; set; }
        public int Humidity { get; set; }
        public int AirPressure { get; set; }
        public double WindSpeed { get; set; }
        public int WindDirection { get; set; }
        public string WeatherIconImg { get; set; }
        public string Cloudcovercondition { get; set; }
    }
}