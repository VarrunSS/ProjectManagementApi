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
                ,ISNULL([Team], '') as Team
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
                        detail.Team = Convert.ToString (reader["Team"]);

                        result.Add (detail);
                    }
                    reader.Close ();
                } catch (Exception ex) {
                    throw ex;
                }
            }

            return result;
        }

        public static List<Performance> GetPerformanceDetails () {
            List<Performance> result = new List<Performance> ();

            string connectionString =
                "Data Source=DELL\\ALIENSERVER;Initial Catalog=Bits;" +
                "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                @"
                select
                Category as TeamName, Count(Distinct Assignee) as TeamSize , Count(Summary) as TotalTaskCompleted, 
                Count(Summary) /  Count(Distinct Assignee) as TaskCompletedPerPerson
                from JiraTickets
                Group by Category
                order by TaskCompletedPerPerson desc
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
                        Performance detail = new Performance ();
                        detail.TeamName = Convert.ToString (reader["TeamName"]);
                        detail.TeamSize = Convert.ToInt32 (reader["TeamSize"]);
                        detail.TotalTaskCompleted = Convert.ToInt32 (reader["TotalTaskCompleted"]);

                        result.Add (detail);
                    }
                    reader.Close ();
                } catch (Exception ex) {
                    throw ex;
                }
            }

            return result;
        }

        public static List<UserTask> GetUserTaskDetails () {
            List<UserTask> result = new List<UserTask> ();

            string connectionString =
                "Data Source=DELL\\ALIENSERVER;Initial Catalog=Bits;" +
                "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                @"                
                SELECT distinct
                EmpID, EmpName, Designation, Experience, Team, Type, Summary, Difficulty, CompletionInDays
                FROM [dbo].[EmployeeInformation] as E
                INNER JOIN [dbo].[JiraTickets] as J
                ON (E.EmpID = J.Assignee)
                ORDER BY EmpName, Type desc, Difficulty desc, Summary;
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
                        UserTask detail = new UserTask ();
                        detail.ID = Convert.ToString (reader["EmpID"]);
                        detail.Name = Convert.ToString (reader["EmpName"]);
                        detail.Designation = Convert.ToString (reader["Designation"]);
                        detail.Experience = Convert.ToString (reader["Experience"]);
                        detail.Team = Convert.ToString (reader["Team"]);

                        detail.TaskType = Convert.ToString (reader["Type"]);
                        detail.Summary = Convert.ToString (reader["Summary"]);
                        detail.Difficulty = Convert.ToString (reader["Difficulty"]);
                        detail.CompletionInDays = Convert.ToDecimal (reader["CompletionInDays"]);

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