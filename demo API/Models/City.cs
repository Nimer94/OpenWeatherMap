using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace demo_API.Models
{
    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public int MainID { get; set; }
        public int WeatherID { get; set; }
        public int WindID { get; set; }
        public virtual Main Main { get; set; }
        public virtual Weather Weather { get; set; }
        public virtual Wind Wind { get; set; }
    }
}