﻿using Solentive.Interview.Model;
using Solentive.Interview.Service;
using Solentive.Interview.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solentive.Interview.WebUI.Controllers
{
    public class TrackController : Controller
    {
        private readonly ITrackService _trackService = null;

        public TrackController(ITrackService trackService)
        {
            _trackService = trackService;
        }

        [HttpGet]
        public ActionResult List()
        {
            // Get the source list and map to the view model type.
            var list = _trackService.GetTracks();
            return View(list);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new Track();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Track track)
        {
            if (ModelState.IsValid)
            {
                var result = _trackService.AddTrack(track);
                ViewBag.HasSaved = result;
            }

            return View(track);
        }
    }
}
