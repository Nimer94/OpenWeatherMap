using demo_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace demo_API.Repository
{
    public class CityManagerRepository : ICityManagerRepository
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        public async Task<City> CreateCity(City CityToCreate)
        {       
                _db.Cities.Add(CityToCreate);
                await _db.SaveChangesAsync();
                return CityToCreate;          
        }
      
        public async Task<bool> DeleteCity(int id)
        {
            var city = await _db.Cities.Include(c => c.Main).Include(c => c.Weather).Include(c => c.Wind).SingleOrDefaultAsync(p => p.CityID == id);
            var weather = city.Weather;
            var main = city.Main;
            var wind = city.Wind;
            _db.Weathers.Remove(weather);
            _db.Mains.Remove(main);
            _db.Winds.Remove(wind);
            _db.Cities.Remove(city);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCityWeather(int id)
        {
            var originalcity =await _db.Weathers.SingleOrDefaultAsync(p => p.WeatherID == id);
            _db.Weathers.Remove(originalcity);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCityWind(int id)
        {
            var originalcity =await _db.Winds.SingleOrDefaultAsync(p => p.WindID == id);
            _db.Winds.Remove(originalcity);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCityMain(int id)
        {
            var originalcity =await _db.Mains.SingleOrDefaultAsync(p => p.MainID == id);
            _db.Mains.Remove(originalcity);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<City> EditCity(City CityToEdit)
        {
            var originalcity = await  _db.Cities.SingleOrDefaultAsync(p => p.CityID == CityToEdit.CityID);
            originalcity = CityToEdit;
           await _db.SaveChangesAsync();
            return CityToEdit;
        }

        public async Task<City> GetCity(int id)
        {
            return await _db.Cities.SingleOrDefaultAsync(p => p.CityID == id);
        }

             
        public async Task<IEnumerable<City>> ListCities()
        {
            return await _db.Cities.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<City> GetCityByName(string cityname)
        {
             return await _db.Cities.FirstOrDefaultAsync(p => p.Name == cityname);

        }

        public async Task<Weather> CreateCityWeather(Weather weatherToCreate)
        {           
            _db.Weathers.Add(weatherToCreate);
            await _db.SaveChangesAsync();
            return weatherToCreate;
        }

        public async Task<Wind> CreateCityWind(Wind windToCreate)
        {
            _db.Winds.Add(windToCreate);
            await _db.SaveChangesAsync();
            return windToCreate;
        }

        public async Task<Main> CreateCityMain(Main MainToCreate)
        {
            _db.Mains.Add(MainToCreate);
            await _db.SaveChangesAsync();
            return MainToCreate;
        }



    }
}