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
    }
}
