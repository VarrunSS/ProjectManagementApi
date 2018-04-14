using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementApi.DataAccessLayer;
using ProjectManagementApi.Models;

namespace ProjectManagementApi.Controllers {
    [Route ("api/[controller]")]
    public class UserTaskController : Controller {
        [HttpGet]
        public List<UserTask> Get () {
            // return ProjectManagementDAL.GetDummyUserTaskDetails ();
            return ProjectManagementDAL.GetUserTaskDetails ();
        }
    }
}