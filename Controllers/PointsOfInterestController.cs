using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityApi.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null) 
            {
                return NotFound();
            } 

            return Ok(city.PointsOfInterest);
        }


        [HttpGet("{cityId}/pointsofinterest/{id}")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
             var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null) 
            {
                return NotFound();
            }

            var poi = city.PointsOfInterest.FirstOrDefault( p => p.Id == id); 

            if (poi == null)
            {
                return NotFound();
            }

            return Ok(poi);
        }
    }
}