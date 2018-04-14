using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementApi.DataAccessLayer;
using ProjectManagementApi.Models;

namespace ProjectManagementApi.Controllers {
    [Route("api/[controller]")]
    public class PerformanceController : Controller {

        [HttpGet]
        public List<Performance> Get () {
            // return ProjectManagementDAL.GetDummyPerformanceDetails ();
            return ProjectManagementDAL.GetPerformanceDetails ();
        }
    }
}