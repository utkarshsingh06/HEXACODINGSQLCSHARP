using CareerHub.Models;
using CareerHub.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Services
{
    internal class ApplicationsService:IApplicationsService
    {
        readonly IApplicationsRepository _applicationsRepository;

        public ApplicationsService(IApplicationsRepository applicationsRepository)
        {
            _applicationsRepository= applicationsRepository;
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

        public void insertApp(Applications applications)
        {
            int insertstatus = _applicationsRepository.insertApplications(applications);
            if (insertstatus > 0)
            {

                Console.WriteLine(insertstatus);
            }
            else
            {
                Console.WriteLine("error in insertion");
            }
        }

        public int insertapplicant(Applicants applicant)
        {
            throw new NotImplementedException();
        }
    }
}
