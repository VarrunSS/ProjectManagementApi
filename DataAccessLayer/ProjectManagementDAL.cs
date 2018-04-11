using System;
using ProjectManagementApi.Models;
using System.Collections.Generic;

namespace ProjectManagementApi.DataAccessLayer
{
    public class ProjectManagementDAL
    {
        public static List<Employee> GetDummyEmployeeDetails()
        {
            // Connect to Database through ADO.NET HERE.
            // test

            return new List<Employee>() {
                new Employee() {
                    ID = "Varun",
                    Name = "Varun SS",
                    Designation = "Tech",
                    Experience = "3.5"
                 },
                 new Employee() {
                    ID = "Dhoni",
                    Name = "Dhoni MS",
                    Designation = "Keeper",
                    Experience = "10"
                 },
                 new Employee() {
                    ID = "Raina",
                    Name = "Raina S",
                    Designation = "Batsman",
                    Experience = "7"
                 },
                 new Employee() {
                    ID = "Koli",
                    Name = "Koli V",
                    Designation = "Captain",
                    Experience = "6"
                 },
                   new Employee() {
                    ID = "Sachin",
                    Name = "Sachin Tendulkar",
                    Designation = "Legend",
                    Experience = "20"
                 }
            };
        }


        public static List<Employee> GetEmployeeDetails(List<string> IDs)
        {
            // Connect to Database through ADO.NET HERE.
            // test

            return new List<Employee>() {
                new Employee() {
                    ID = "Varun",
                    Name = "Varun SS",
                    Designation = "Tech",
                    Experience = "3.5"
                 },
                 new Employee() {
                    ID = "Dhoni",
                    Name = "Dhoni MS",
                    Designation = "Keeper",
                    Experience = "10"
                 },
                 new Employee() {
                    ID = "Raina",
                    Name = "Raina S",
                    Designation = "Batsman",
                    Experience = "7"
                 },
                 new Employee() {
                    ID = "Koli",
                    Name = "Koli V",
                    Designation = "Captain",
                    Experience = "6"
                 },
                   new Employee() {
                    ID = "Sachin",
                    Name = "Sachin Tendulkar",
                    Designation = "Legend",
                    Experience = "20"
                 }
            };
        }
    }
}