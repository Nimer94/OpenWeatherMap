using demo_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_API.Services
{
    public interface ICityManagerService
    {
        Task<City> CreateCity(City CityToCreate);
        Task<City> EditCity(City CityToEdit);
        Task<bool> DeleteCity(int id);
        Task<City> GetCity(int id);
        Task<IEnumerable<City>> ListCities();
        Task<City> GetCityByName(string cityname);
        Task<Weather> CreateCityWeather(Weather weatherToCreate);
        Task<Wind> CreateCityWind(Wind windToCreate);
        Task<Main> CreateCityMain(Main weatherToCreate);


    }
}
