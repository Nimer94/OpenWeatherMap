using demo_API.Models;
using demo_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace demo_API.Services
{
    public class CityManagerService : ICityManagerService
    {
        private ICityManagerRepository _repository;


        public CityManagerService() : this(new CityManagerRepository())
        { }

        //Test
        public CityManagerService(ICityManagerRepository repository)
        {
            _repository = repository;
        }


        public async Task<City> CreateCity(City cityToCreate)
        {            
            return await _repository.CreateCity(cityToCreate);            
        }


        public async Task<bool> DeleteCity(int id)
        {
            try
            {
               await _repository.DeleteCity(id);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async Task<City> EditCity(City cityToEdit)
        {
            City city = new City { CityID = 0 };
            try
            {
                city = await _repository.EditCity(cityToEdit);
            }
            catch
            {
                return city;
            }
            return city;
        }

        public async Task<City> GetCity(int id)
        {
            return await _repository.GetCity(id);
        }

               
        public async Task<IEnumerable<City>> ListCities()
        {
            return await _repository.ListCities();
        }

        public async Task<City> GetCityByName(string cityname)
        {
            return await _repository.GetCityByName(cityname);
        }

        public async Task<Weather> CreateCityWeather(Weather weatherToCreate)
        {
            Weather weather = new Weather { WeatherID = 0 };
            try
            {
                weather = await _repository.CreateCityWeather(weatherToCreate);

            }
            catch
            {
                return weather;
            }
            return weather;
        }

        public async Task<Wind> CreateCityWind(Wind windToCreate)
        {
            Wind wind = new Wind { WindID = 0 };
            try
            {
                wind = await _repository.CreateCityWind(windToCreate);

            }
            catch
            {
                return wind;
            }
            return wind;
        }

        public async Task<Main> CreateCityMain(Main windToCreate)
        {
            Main miain = new Main { MainID = 0 };
            try
            {
                miain = await _repository.CreateCityMain(windToCreate);

            }
            catch
            {
                return miain;
            }
            return miain;
        }

    }
}