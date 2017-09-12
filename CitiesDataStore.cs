using System.Collections.Generic;
using CityApi.Models;

namespace CityApi
{
    class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto() 
                {
                    Id = 1,
                    Name = "Bergen",
                    Description = "The wet one",
                    PointsOfInterest = new List<PointOfInterestDto>() 
                    {
                        new PointOfInterestDto() 
                        {
                            Id = 1,
                            Name = "Blå stein",
                            Description = "A lagre blue stone"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Fisketorget",
                            Description = "A place where they sell overpriced seafood to tourists."
                        }
                    }
                },
                new CityDto() 
                {
                    Id = 2,
                    Name = "Oslo",
                    Description = "The capital",
                    PointsOfInterest = new List<PointOfInterestDto>() 
                    {
                        new PointOfInterestDto() 
                        {
                            Id = 3,
                            Name = "Slottet",
                            Description = "A house where the king and queen lives"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Stortinget",
                            Description = "A place mostly bad people work, and some good."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Castelnuovo Calcea",
                    Description = "Home?",
                    PointsOfInterest = new List<PointOfInterestDto>() 
                    {
                        new PointOfInterestDto() 
                        {
                            Id = 5,
                            Name = "Cascina Allegria",
                            Description = "A fantastic agriturismo"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "The castel",
                            Description = "A landmark in the area."
                        }
                    }
                }
            };
        }
    }
}