using demo_API.Models;
using demo_API.Services;
using demo_API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace demo_API.Controllers
{
    public class WeathersController : Controller
    {
        private ICityManagerService _cityManagerService;

        public WeathersController()
        {
            _cityManagerService = new CityManagerService();
            //_weatherManagerService = new WeatherManagerService();
        }

        [HttpGet]
        public  ActionResult DashBoard()
        {
            CRUDWeatherViewModel cRUDWeatherViewModel = new CRUDWeatherViewModel();
            ViewBag.Cities = _cityManagerService.ListCities();
            return View(cRUDWeatherViewModel);
        }
       
        [HttpPost]
        public async Task<ActionResult> Create(CRUDWeatherViewModel ViewWeather)
        {
            var cityWeather = await _cityManagerService.GetCityByName(ViewWeather.CityName);
            if (cityWeather != null)
            {
                await _cityManagerService.DeleteCity(cityWeather.CityID);
            }
            Weather weather = new Weather
            {
                Cloudcovercondition = ViewWeather.Cloudcovercondition,
                WeatherIconImg = ViewWeather.WeatherIconImg
            };
            var weatheresult = await _cityManagerService.CreateCityWeather(weather);
            if (weatheresult.WeatherID != 0)
            {
                Wind wind = new Wind
                {
                    WindDirection = ViewWeather.WindDirection,
                    WindSpeed = ViewWeather.WindSpeed,
                };
                var windResult = await _cityManagerService.CreateCityWind(wind);
                if (windResult.WindID != 0)
                {
                    Main main = new Main
                    {
                        AirPressure = ViewWeather.AirPressure,
                        CurrentTemperature = ViewWeather.CurrentTemperature,
                        Humidity = ViewWeather.Humidity,
                        MaximumTemperature = ViewWeather.MaximumTemperature,
                        MinimumTemperature = ViewWeather.MinimumTemperature
                    };
                    var mainResult = await _cityManagerService.CreateCityMain(main);
                    if (windResult.WindID != 0)
                    {
                        City city = new City
                        {
                            Name = ViewWeather.CityName,
                            CountryCode = ViewWeather.CountryCode,
                            MainID = mainResult.MainID,
                            WindID = windResult.WindID,
                            WeatherID = weatheresult.WeatherID
                        };
                        var cityResult = await _cityManagerService.CreateCity(city);
                        if (cityResult.CityID != 0)
                        {
                            var cityWeather1 = await _cityManagerService.GetCity(cityResult.CityID);
                            CRUDWeatherViewModel cRUDWeatherViewModel = new CRUDWeatherViewModel
                            {
                                AirPressure = cityWeather1.Main.AirPressure,
                                CityName = cityWeather1.Name + ", " + cityWeather1.CountryCode,
                                CurrentTemperature = cityWeather1.Main.CurrentTemperature,
                                Humidity = cityWeather1.Main.Humidity,
                                MaximumTemperature = cityWeather1.Main.MaximumTemperature,
                                MinimumTemperature = cityWeather1.Main.MaximumTemperature,
                                Cloudcovercondition = cityWeather1.Weather.Cloudcovercondition,
                                WindDirection = cityWeather1.Wind.WindDirection,
                                WindSpeed = cityWeather1.Wind.WindSpeed,
                                WeatherIconImg = cityWeather1.Weather.WeatherIconImg,
                            };
                            return PartialView("_WeatherInfoPartial", cRUDWeatherViewModel);
                        }
                        else
                        {
                            return Json(new { success = false }, JsonRequestBehavior.AllowGet);
                        }
                    }
                    else
                    {
                        return Json(new { success = false }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { success = false }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            }
        }

      

        


       

       




       


        // GET: CityWeather
        public ActionResult Index()
        {
            return View();
        }
    }
}