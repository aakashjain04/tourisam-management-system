using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourismMangementSystemService.Models;
using TourismMangementSystemService.Models.dto;

namespace TourismMangementSystemService.Controllers
{
    public class TourController : ApiController
    {
        public HttpResponseMessage Get()
        {         
            using(TourismManagementSystemEntities entities = new TourismManagementSystemEntities())
            {              
                List<CountryDto> countryDtoList = new List<CountryDto>();               
                foreach(var country in entities.COUNTRies.ToList())
                {
                    countryDtoList.Add(
                            new CountryDto
                            {
                                CountryId = country.CountryID,
                                CountryName = country.CountryName,
                                RegionId = country.RegionID
                            }
                        );
                }
               
                return Request.CreateResponse(HttpStatusCode.OK, countryDtoList);
            }
                
                  
        }

        public HttpResponseMessage Get(int id)
        {
            using (TourismManagementSystemEntities entities = new TourismManagementSystemEntities())
            {
                CountryDto countryDto = new CountryDto();
                COUNTRY country = entities.COUNTRies.Where(c => c.CountryID == id).SingleOrDefault();
                countryDto.CountryId = country.CountryID;
                countryDto.CountryName = country.CountryName;
                countryDto.RegionId = country.RegionID;
                return Request.CreateResponse(HttpStatusCode.OK, countryDto);
            }


        }

        public HttpResponseMessage Post(CountryDto countryDto)
        {
            using (TourismManagementSystemEntities entities = new TourismManagementSystemEntities())
            {
                COUNTRY country = new COUNTRY();
                country.CountryName = countryDto.CountryName;
                country.RegionID = countryDto.RegionId;
                country.UpdationDate = null;
                entities.COUNTRies.Add(country);
                entities.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created);
            }


        }

        public HttpResponseMessage Put(int id, CountryDto countryDto)
        {
            using (TourismManagementSystemEntities entities = new TourismManagementSystemEntities())
            {
                COUNTRY country = entities.COUNTRies.Where(c => c.CountryID == id).SingleOrDefault();               
                country.CountryName = countryDto.CountryName;
                country.RegionID = countryDto.RegionId;
                country.UpdationDate = null;                
                entities.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            using (TourismManagementSystemEntities entities = new TourismManagementSystemEntities())
            {
                COUNTRY coutry = entities.COUNTRies.Where(c => c.CountryID == id).SingleOrDefault();
                entities.COUNTRies.Remove(coutry);
                entities.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }
    }
}
