﻿using Solentive.Interview.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Service.Interfaces
{
    public interface ITrackService
    {
        IList<Track> GetTracks();
        bool AddTrack(Track track);
    }
}
