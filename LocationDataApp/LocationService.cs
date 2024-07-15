using System;
using System.Collections.Generic;
using System.Linq;

namespace LocationDataApp
{
    public class LocationService
    {
        public List<LocationData> InitializeData()
        {
            return new List<LocationData>
            {
                new LocationData { ID = Guid.NewGuid(), Code = "Z123", Name = "Location1" },
                new LocationData { ID = Guid.NewGuid(), Code = "A456", Name = "Location2" },
                new LocationData { ID = Guid.NewGuid(), Code = "Z789", Name = "Location3" }
            };
        }

        public List<string> GetNamesWithCodeStartingWithZ(List<LocationData> locations)
        {
            return locations
                .Where(location => location.Code.StartsWith("Z"))
                .Select(location => location.Name)
                .ToList();
        }
    }
}