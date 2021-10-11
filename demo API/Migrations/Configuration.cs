

using demo_API.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Text;
//using System.Text.Json;


using System.Threading.Tasks;

namespace demo_API.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<demo_API.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(demo_API.Models.ApplicationDbContext context)
        {
            if (!context.Cities.Any())
            {
                GetWeathers().ForEach(c => context.Weathers.Add(c));
                context.SaveChanges();


                GetWinds().ForEach(c => context.Winds.Add(c));
                context.SaveChanges();


                GetMains().ForEach(c => context.Mains.Add(c));
                context.SaveChanges();


                GetCities().ForEach(c => context.Cities.Add(c));
                context.SaveChanges();

                //CreateCitiesWeather(context);



            }




        }

        private static List<Weather> GetWeathers()
        {
            var Weathers = new List<Weather>();
            Weathers.Add(new Weather
            {
                Cloudcovercondition = "http://openweathermap.org/img/w/01n.png",
                WeatherIconImg = "Clear"
            });
            Weathers.Add(new Weather
            {
                Cloudcovercondition = "http://openweathermap.org/img/w/01n.png",
                WeatherIconImg = "Clear"
            });
            Weathers.Add(new Weather
            {
                Cloudcovercondition = "http://openweathermap.org/img/w/01n.png",
                WeatherIconImg = "Clear"
            });
            Weathers.Add(new Weather
            {
                Cloudcovercondition = "http://openweathermap.org/img/w/01n.png",
                WeatherIconImg = "Clear"
            });
            Weathers.Add(new Weather
            {
                Cloudcovercondition = "http://openweathermap.org/img/w/01n.png",
                WeatherIconImg = "Clear"
            });
            Weathers.Add(new Weather
            {
                Cloudcovercondition = "http://openweathermap.org/img/w/01n.png",
                WeatherIconImg = "Clear"
            });
            Weathers.Add(new Weather
            {
                Cloudcovercondition = "http://openweathermap.org/img/w/01n.png",
                WeatherIconImg = "Clear"
            });
            Weathers.Add(new Weather
            {
                Cloudcovercondition = "http://openweathermap.org/img/w/01n.png",
                WeatherIconImg = "Clear"
            });
            Weathers.Add(new Weather
            {
                Cloudcovercondition = "http://openweathermap.org/img/w/01n.png",
                WeatherIconImg = "Clear"
            });
            Weathers.Add(new Weather
            {
                Cloudcovercondition = "http://openweathermap.org/img/w/01n.png",
                WeatherIconImg = "Clear"
            });
            return Weathers;

        }

        private static List<Wind> GetWinds()
        {
            var Winds = new List<Wind>();
            Winds.Add(new Wind
            {
                WindSpeed = 1.34,
                WindDirection = 210
            });
            Winds.Add(new Wind
            {
                WindSpeed = 1.34,
                WindDirection = 210
            });
            Winds.Add(new Wind
            {
                WindSpeed = 1.34,
                WindDirection = 210
            });
            Winds.Add(new Wind
            {
                WindSpeed = 1.34,
                WindDirection = 210
            });
            Winds.Add(new Wind
            {
                WindSpeed = 1.34,
                WindDirection = 210
            });
            Winds.Add(new Wind
            {
                WindSpeed = 1.34,
                WindDirection = 210
            });
            Winds.Add(new Wind
            {
                WindSpeed = 1.34,
                WindDirection = 210
            });
            Winds.Add(new Wind
            {
                WindSpeed = 1.34,
                WindDirection = 210
            });
            Winds.Add(new Wind
            {
                WindSpeed = 1.34,
                WindDirection = 210
            });
            Winds.Add(new Wind
            {
                WindSpeed = 1.34,
                WindDirection = 210
            });
            return Winds;
        }

        private static List<Main> GetMains()
        {
            var Mains = new List<Main>();
            Mains.Add(new Main
            {
                CurrentTemperature = 4.6,
                MinimumTemperature = 2.74,
                 MaximumTemperature = 8.02,
                Humidity = 83,
                 AirPressure = 1022,
            });
            Mains.Add(new Main
            {
                CurrentTemperature = 4.6,
                MinimumTemperature = 2.74,
                MaximumTemperature = 8.02,
                Humidity = 83,
                AirPressure = 1022,
            });
            Mains.Add(new Main
            {
                CurrentTemperature = 4.6,
                MinimumTemperature = 2.74,
                MaximumTemperature = 8.02,
                Humidity = 83,
                AirPressure = 1022,
            });
            Mains.Add(new Main
            {
                CurrentTemperature = 4.6,
                MinimumTemperature = 2.74,
                MaximumTemperature = 8.02,
                Humidity = 83,
                AirPressure = 1022,
            });
            Mains.Add(new Main
            {
                CurrentTemperature = 4.6,
                MinimumTemperature = 2.74,
                MaximumTemperature = 8.02,
                Humidity = 83,
                AirPressure = 1022,
            });
            Mains.Add(new Main
            {
                CurrentTemperature = 4.6,
                MinimumTemperature = 2.74,
                MaximumTemperature = 8.02,
                Humidity = 83,
                AirPressure = 1022,
            });
            Mains.Add(new Main
            {
                CurrentTemperature = 4.6,
                MinimumTemperature = 2.74,
                MaximumTemperature = 8.02,
                Humidity = 83,
                AirPressure = 1022,
            });
            Mains.Add(new Main
            {
                CurrentTemperature = 4.6,
                MinimumTemperature = 2.74,
                MaximumTemperature = 8.02,
                Humidity = 83,
                AirPressure = 1022,
            });
            Mains.Add(new Main
            {
                CurrentTemperature = 4.6,
                MinimumTemperature = 2.74,
                MaximumTemperature = 8.02,
                Humidity = 83,
                AirPressure = 1022,
            });
            Mains.Add(new Main
            {
                CurrentTemperature = 4.6,
                MinimumTemperature = 2.74,
                MaximumTemperature = 8.02,
                Humidity = 83,
                AirPressure = 1022,
            });
            return Mains;

        }

        private static List<City> GetCities()
        {
            var Cities = new List<City>();
            Cities.Add(new City
            {
                Name = "Erfurt",
                CountryCode = "DE",
                MainID = 1,
                WeatherID = 1,
                WindID = 1,
            });
            Cities.Add(new City
            {
                Name = "Frankfurt am Main",
                CountryCode = "DE",
                MainID = 2,
                WeatherID = 2,
                WindID = 2,
            });
            Cities.Add(new City
            {
                Name = "Berlin",
                CountryCode = "DE",
                MainID = 3,
                WeatherID = 3,
                WindID = 3,
            });
            Cities.Add(new City
            {
                Name = "Bruchsal",
                CountryCode = "DE",
                MainID = 4,
                WeatherID = 4,
                WindID = 4,
            });
            Cities.Add(new City
            {
                Name = "Kaiserslautern",
                CountryCode = "DE",
                MainID = 5,
                WeatherID = 5,
                WindID = 5,
            });
            Cities.Add(new City
            {
                Name = "Karlsruhe",
                CountryCode = "DE",
                MainID = 6,
                WeatherID = 6,
                WindID = 6,
            });
            Cities.Add(new City
            {
                Name = "Mannheim",
                CountryCode = "DE",
                MainID = 7,
                WeatherID = 7,
                WindID = 7,
            });
            Cities.Add(new City
            {
                Name = "Saarbrücken",
                CountryCode = "DE",
                MainID = 8,
                WeatherID = 8,
                WindID = 8,
            });
            Cities.Add(new City
            {
                Name = "Stuttgart",
                CountryCode = "DE",
                MainID = 9,
                WeatherID = 9,
                WindID = 9,
            });
            Cities.Add(new City
            {
                Name = "Heidelberg",
                CountryCode = "DE",
                MainID = 10,
                WeatherID = 10,
                WindID = 10,
            });
            return Cities;
        }


        //private void CreateCitiesWeather(ApplicationDbContext context)
        //{

        //    if (!context.Cities.Any())
        //    {
        //        var weathersdata =
        //            File.ReadAllText("../SeedData/weathers.json", Encoding.Default);

        //        var weathers = JsonSerializer.Deserialize<List<Weather>>(weathersdata);

        //        foreach (var item in weathers)
        //        {
        //            context.Weathers.Add(item);
        //        }
        //         context.SaveChanges();
        //    }

        //    if (!context.Winds.Any())
        //    {
        //        var windsdata =
        //            File.ReadAllText("../SeedData/winds.json", Encoding.Default); 

        //        var winds = JsonSerializer.Deserialize<List<Wind>>(windsdata);

        //        foreach (var item in winds)
        //        {
        //            context.Winds.Add(item);
        //        }

        //         context.SaveChanges();
        //    }

        //    if (!context.Mains.Any())
        //    {
        //        var mainsdata =
        //            File.ReadAllText("../SeedData/mains.json", Encoding.Default);

        //        var mains = JsonSerializer.Deserialize<List<Main>>(mainsdata);

        //        foreach (var item in mains)
        //        {
        //            context.Mains.Add(item);
        //        }

        //        context.SaveChanges();
        //    }

        //    if (!context.Cities.Any())
        //    {
        //        var citiesdata =
        //            File.ReadAllText("../SeedData/cities.json", Encoding.Default);

        //        var cities = JsonSerializer.Deserialize<List<City>>(citiesdata);

        //        foreach (var item in cities)
        //        {
        //            context.Cities.Add(item);
        //        }

        //        context.SaveChanges();
        //    }
        //}
    }
}