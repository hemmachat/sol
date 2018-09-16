using Solentive.Interview.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solentive.Interview.Service.Interfaces
{
    public interface ILocationService
    {
        IList<Location> GetLocations();
        bool AddLocation(Location location);
    }
}