using CareerHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Services
{
    internal interface IApplicationsService
    {
        public void CreateProfile(string email, string firstName, string lastname, string phone);
        public void ApplyForJob(int jobID, string coverLetter);
        public int insertapplicant(Applicants applicant);
        public List<Applicants> GetApplicants();
        public void insertApp(Applications applications);
    }
}
