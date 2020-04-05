using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="DG City",
                    Description="thE one with park",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name="1ssss as",
                            Description= "1test xvxvxvxv"
                        },
                        new PointOfInterestDto()
                        {
                            Id=2,
                            Name="2ssss as",
                            Description= "2test xvxvxvxv"
                        }
                    }
                },
                new CityDto()
                {
                    Id=2,
                    Name="Bedzin",
                    Description="regular one",
                     PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=3,
                            Name="14ssss as",
                            Description= "14test xvxvxvxv"
                        },
                        new PointOfInterestDto()
                        {
                            Id=4,
                            Name="23ssss as",
                            Description= "23test xvxvxvxv"
                        }
                    }
                },
                new CityDto()
                {
                    Id=3,
                    Name="Sosnowiec",
                    Description="the one from jokes",
                     PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=5,
                            Name="51ssss as",
                            Description= "51test xvxvxvxv"
                        },
                        new PointOfInterestDto()
                        {
                            Id=6,
                            Name="26ssss as",
                            Description= "62test xvxvxvxv"
                        }
                    }
                }
            };
        }
    }
}
