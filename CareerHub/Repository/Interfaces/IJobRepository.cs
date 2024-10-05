using CareerHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Repository.Interfaces
{
    internal interface IJobRepository
    {
        public int Applyjob(int applicantID, string coverLetter);
        public List<Applicants> GetApplicants();
        public int insertjobs(Jobs job);
        public List<Jobs> GetJobs();

        public List<Jobs> getjobsbysalaryrange(decimal minsalary,decimal maxsalary);
    }
}
