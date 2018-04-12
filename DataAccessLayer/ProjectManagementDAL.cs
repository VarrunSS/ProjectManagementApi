using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProjectManagementApi.Models;

namespace ProjectManagementApi.DataAccessLayer {
    public class ProjectManagementDAL {
        public static List<Employee> GetDummyEmployeeDetails () {
            // Connect to Database through ADO.NET HERE.
            // test

            return new List<Employee> () {
                new Employee () {
                        ID = "Varun",
                            Name = "Varun SS",
                            Designation = "Tech",
                            Experience = "3.5"
                    },
                    new Employee () {
                        ID = "Dhoni",
                            Name = "Dhoni MS",
                            Designation = "Keeper",
                            Experience = "10"
                    },
                    new Employee () {
                        ID = "Raina",
                            Name = "Raina S",
                            Designation = "Batsman",
                            Experience = "7"
                    },
                    new Employee () {
                        ID = "Koli",
                            Name = "Koli V",
                            Designation = "Captain",
                            Experience = "6"
                    },
                    new Employee () {
                        ID = "Sachin",
                            Name = "Sachin Tendulkar",
                            Designation = "Legend",
                            Experience = "20"
                    }
            };
        }

        public static List<Performance> GetDummyPerformanceDetails () {
            return new List<Performance> () {
                new Performance () {
                        TeamName = "PD Team",
                            TeamSize = 5,
                            TotalTaskCompleted = 98
                    },
                    new Performance () {
                        TeamName = "UX Team",
                            TeamSize = 2,
                            TotalTaskCompleted = 63
                    },
                    new Performance () {
                        TeamName = "Program Team",
                            TeamSize = 20,
                            TotalTaskCompleted = 100
                    }
            };
        }

        public static List<UserTask> GetDummyUserTaskDetails () {
            return new List<UserTask> () {
                new UserTask () {
                    ID = "123",
                        Name = "Varun",
                        Team = "PD Team",
                        Experience = "4"
                }
            };
        }

        public static List<Employee> GetEmployeeDetails () {
            List<Employee> result = new List<Employee> ();

            string connectionString =
                "Data Source=DELL\\ALIENSERVER;Initial Catalog=Bits;" +
                "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                @"
                SELECT [EmpID]
                ,[EmpName]
                ,[Designation]
                ,[Experience]
                FROM [BITS].[dbo].[EmployeeInformation]
                ORDER BY EmpName;
                ";

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection (connectionString)) {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand (queryString, connection);

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try {
                    connection.Open ();
                    SqlDataReader reader = command.ExecuteReader ();
                    while (reader.Read ()) {
                        Employee detail = new Employee ();
                        detail.ID = Convert.ToString (reader["EmpID"]);
                        detail.Name = Convert.ToString (reader["EmpName"]);
                        detail.Designation = Convert.ToString (reader["Designation"]);
                        detail.Experience = Convert.ToString (reader["Experience"]);

                        result.Add (detail);
                    }
                    reader.Close ();
                } catch (Exception ex) {
                    throw ex;
                }
            }

            return result;
        }
    }
}