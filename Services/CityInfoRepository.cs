using System.Collections.Generic;
using System.Linq;
using CityApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityApi.Services
{
    class CityInfoRepository : ICityInfoRepository
    {
        CityInfoContext _context;

        public CityInfoRepository(CityInfoContext context)
        {
            _context = context;    
        }
        IEnumerable<City> ICityInfoRepository.GetCities()
        {
            return _context.Cities.OrderBy(c => c.Name).ToList();
        }

        City ICityInfoRepository.GetCity(int cityId, bool includePointsOfInterest)
        {
            if (includePointsOfInterest) 
            {
                return _context.Cities.Include(c => c.PointsOfInterest)
                    .Where(c => c.Id == cityId).FirstOrDefault();
            }
            return _context.Cities.Where(c => c.Id == cityId).FirstOrDefault();
        }

        PointOfInterest ICityInfoRepository.GetPointOfInterest(int cityId, int pointOfInterestId)
        {
            return _context.PointsOfInterest
                .Where( p => p.CityId == cityId && p.Id == pointOfInterestId).FirstOrDefault();
        }

        IEnumerable<PointOfInterest> ICityInfoRepository.GetPointsOfInterest(int cityId)
        {
            return _context.PointsOfInterest.Where(p => p.CityId == cityId).ToList();
        }
    }
}