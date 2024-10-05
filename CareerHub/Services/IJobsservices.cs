using CareerHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Services
{
    internal interface IJobsservices
    {
        public int Applyjob(int applicantID, string coverLetter);
        public List<Applicants> GetApplicants();
        public void insertjobs(Jobs job);
        public void GetJobs();
        public void getjobsbysalaryrange(decimal minsalary, decimal maxsalary);
    }
}
