using demo_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_API.Repository
{
    public interface ICityManagerRepository
    {
        Task<City> CreateCity(City CityToCreate);
        Task<bool> DeleteCity(int id);
        Task<bool> DeleteCityWeather(int id);
        Task<bool> DeleteCityMain(int id);
        Task<bool> DeleteCityWind(int id);
        Task<City> EditCity(City CityToEdit);
        Task<City> GetCity(int id);
        Task<IEnumerable<City>> ListCities();
        Task<City> GetCityByName(string cityname);
        Task<Weather> CreateCityWeather(Weather weatherToCreate);
        Task<Wind> CreateCityWind(Wind windToCreate);
        Task<Main> CreateCityMain(Main weatherToCreate);


    }
}
