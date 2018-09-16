﻿using Solentive.Interview.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solentive.Interview.Data;
using Solentive.Interview.Service.Interfaces;

namespace Solentive.Interview.Service
{
    public class SeminarService : ISeminarService
    {
        private readonly SeminarDbContext _dbContext = null;

        public SeminarService ()
	    {
            _dbContext = new SeminarDbContext();
	    }

        public IList<Seminar> GetSeminars()
        {
            return _dbContext.Seminars.Include("Location").Include("Level").Include("Track").ToList();
        }
    }
}
