using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sehir_Rehberi.API.Data;
using sehir_Rehberi.API.Dtos;
using sehir_Rehberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sehir_Rehberi.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]


    public class CitiesController : ControllerBase

    {

        private IAppRepository _appRepository;
        private IMapper _mapper;
        private object photos;

        public CitiesController(IAppRepository appRepository, IMapper mapper)

        {
            _appRepository = appRepository;
            _mapper = mapper;
        }
        public ActionResult GetCities()
        {
            var Cities = _appRepository.GetCities();
            var citiesToReturn = _mapper.Map<List<CityForListDto>>(Cities);
            return Ok(citiesToReturn);
        }
        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]City city)
        {
            _appRepository.Add(city);
            _appRepository.SaveAll();
            return Ok(city);
        }
        [HttpPost]
        [Route("detail")]
        public ActionResult GetCitiesById(int id)
        {
            var city = _appRepository.GetCityById(id);
            var cityToReturn = _mapper.Map<CityForDetailDto>(city);
            return Ok(cityToReturn);
        }
        [HttpPost]
        [Route("Photos")]
        public ActionResult GetPhotosById(int cityId)
        {
            var city = _appRepository.GetPhotosByCity(cityId);
            //var photosToReturn = _mapper.Map<List<PhotoForReturnDto>>(city);
            return Ok(city);
        }


    }
}
