using System;
using ProjectManagementApi.Models;
using System.Collections.Generic;

namespace ProjectManagementApi.DataAccessLayer
{
    public class ProjectManagementDAL
    {
        public static List<Employee> GetEmployeeDetails(List<string> IDs)
        {
            // Connect to Database through ADO.NET HERE.
            // test
            
            return new List<Employee>() {
                new Employee(){ID="1", Name="Varun" },
                new Employee(){ID="2", Name="Dhoni" }
            };
        }
    }
}