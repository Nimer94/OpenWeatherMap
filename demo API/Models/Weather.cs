using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace demo_API.Models
{    
    public class Weather
    {
        public int WeatherID { get; set; }
        public string WeatherIconImg { get; set; }
        public string Cloudcovercondition { get; set; }
    }
}