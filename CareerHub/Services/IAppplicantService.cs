using CareerHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Services
{
    internal interface IAppplicantService
    {
        public void CreateProfile(Applicants applicant);
        public void ApplyForJob(int jobID, string coverLetter);
        public void insertapplicant(Applicants applicant);
        public List<Applicants> GetApplicants();
    }
}
