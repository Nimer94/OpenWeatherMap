using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace demo_API.Models
{
    public class Wind
    {
        public int WindID { get; set; }
        public double WindSpeed { get; set; }
        public int WindDirection { get; set; }

    }
}