using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Models
{
    internal class Jobs
    {
        public int JobID { get; set; }
        public int CompanyID { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string JobLocation { get; set; }
        public decimal Salary { get; set; }
        public string JobType { get; set; }
        public DateTime PostedDate { get; set; }

        public Jobs(int jobID, int companyID, string jobTitle, string jobDescription, string jobLocation, decimal salary, string jobType, DateTime postedDate)
        {
            JobID = jobID;
            CompanyID = companyID;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            JobLocation = jobLocation;
            Salary = salary;
            JobType = jobType;
            PostedDate = postedDate;
        }
        public Jobs()
        {
        }
        public override string ToString()
        {
            return $"Job ID: {JobID}, Title: {JobTitle}, Company ID: {CompanyID}, Location: {JobLocation}, Salary: {Salary:C}, " +
                   $"Job Type: {JobType}, Posted Date: {PostedDate.ToShortDateString()}";
        }
    }
}
