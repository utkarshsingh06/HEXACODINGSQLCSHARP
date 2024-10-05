using CareerHub.Models;
using CareerHub.Repository.Interfaces;
using CareerHub.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Repository
{
    internal class JobRepository : IJobRepository
    {
        SqlCommand cmd = null;
        public JobRepository()
        {
            cmd = new SqlCommand();
        }
        public int Applyjob(int applicantID, string coverLetter)
        {
            throw new NotImplementedException();
        }

        public List<Applicants> GetApplicants()
        {
            throw new NotImplementedException();
        }

        public List<Jobs> GetJobs()
        {
            List<Jobs> jobListings= new List<Jobs>();

            using (SqlConnection sqlConnection = new SqlConnection(DbConutil.GetConnString()))
            {
                    cmd.CommandText = "SELECT * FROM Jobs";
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Jobs job = new Jobs()
                            {
                                JobID = (int)reader["job_id"],
                                CompanyID = (int)reader["company_id"],
                                JobTitle = (string)reader["job_title"],
                                JobDescription = (string)reader["job_description"],
                                JobLocation = (string)reader["job_location"],
                                JobType = (string)reader["job_type"],
                                PostedDate = (DateTime)reader["posted_date"]
                            };
                        if (reader["salary"] != DBNull.Value)
                        {
                            job.Salary = (decimal)reader["salary"];
                        }
                        else
                        {
                            job.Salary = 0; 
                        }
                        jobListings.Add(job);
                    }
                    }
            }
            return jobListings;
        }

        public int  insertjobs(Jobs job)
        {
            return 0;
        }
    }
}
