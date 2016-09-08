using Classroom.Api.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Classroom.Api.Controllers
{
    public class DashboardController : ApiController
    {
        private ClassroomDataContext _db;

        public DashboardController()
        {
            _db = new ClassroomDataContext();
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new
            {
                StudentCount = _db.Students.Count(),
                ProjectCount = _db.Projects.Count(),
                AssignmentCount = _db.Assignments.Count()

            });
        }
    }
}