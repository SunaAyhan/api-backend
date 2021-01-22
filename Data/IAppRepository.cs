using sehir_Rehberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sehir_Rehberi.API.Data
{
   public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity);
        bool SaveAll();
        List<City> GetCities();
        List<photo> GetPhotosByCity(int cityId);
        City GetCityById(int cityId);
        photo GetPhoto(int id);

    }
}
