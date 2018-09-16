using Solentive.Interview.Common;
using Solentive.Interview.Model;
using Solentive.Interview.Service;
using Solentive.Interview.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solentive.Interview.WebUI.Controllers
{
    public class SeminarController : Controller
    {
        private readonly ISeminarService _seminarService = null;

        public SeminarController(ISeminarService seminarService)
        {
            _seminarService = seminarService;
        }

        [HttpGet]
        public ActionResult List()
        {
            // Set the week start and end
            ViewBag.WeekStart = DateCalculations.GetWeekStartDate(DateTime.Now).ToShortDateString();
            ViewBag.WeekEnd = DateCalculations.GetWeekEndDate(DateTime.Now).ToShortDateString();

            // Get the source list and map to the view model type.
            var list = _seminarService.GetSeminars();
            return View(list);
        }
    }
}
