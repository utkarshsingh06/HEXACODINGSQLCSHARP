using CareerHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Repository.Interfaces
{
    internal interface IApplicantRepository
    {
        public int CreateProfile(Applicants applicant);
        public void ApplyForJob(int jobID, string coverLetter);
        public int insertapplicant(Applicants applicant);
        public List<Applicants> GetApplicants();
    }
}
