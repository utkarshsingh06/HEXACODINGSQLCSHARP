using CareerHub.Models;
using CareerHub.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Services
{
    internal class ApplicantService:IApplicantRepository
    {
        readonly IApplicantRepository _applicantRepository;
        public ApplicantService(IApplicantRepository applicantRepository)
        {
            _applicantRepository=applicantRepository;
        }

        public void ApplyForJob(int jobID, string coverLetter)
        {
            throw new NotImplementedException();
        }

        public void CreateProfile(string email, string firstName, string lastname, string phone)
        {
            throw new NotImplementedException();
        }

        public List<Applicants> GetApplicants()
        {
            throw new NotImplementedException();
        }

        public int insertapplicant(Applicants applicant)
        {
            int insertstatus = _applicantRepository.insertapplicant(applicant);
            return insertstatus;
        }
    }
}
