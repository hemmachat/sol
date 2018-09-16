using Solentive.Interview.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using Solentive.Interview.Model;
using Solentive.Interview.Data;
using Solentive.Interview.Service.Interfaces;
using Solentive.Interview.Model.Interfaces;
using NLog;

namespace Solentive.Interview.WebUI.Controllers
{
    public class LevelController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IRepository<Level> _repository = null;

        public LevelController(IRepository<Level> repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public ActionResult List()
        {
            var targetList = _repository.GetAll().ToList();

            return View(targetList);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new Level();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Level level)
        {
            if(ModelState.IsValid)
            {
                _repository.Add(level);

                try
                {
                    _repository.SaveChanges();
                    ViewBag.HasSaved = true;
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                    ViewBag.HasSaved = false;
                }
            }

            return View(level);
        }
    }
}
