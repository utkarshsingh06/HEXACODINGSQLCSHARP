using CareerHub.Models;
using CareerHub.Repository;
using CareerHub.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CareerHub.Services
{
    internal class JobsService:IJobsservices
    {
        readonly IJobRepository _jobRepository;
        public JobsService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public int Applyjob(int applicantID, string coverLetter)
        {
            throw new NotImplementedException();
        }

        public List<Applicants> GetApplicants()
        {
            throw new NotImplementedException();
        }

        public void GetJobs()
        {
            List<Jobs> job1 = _jobRepository.GetJobs();
            foreach(Jobs item in job1)
            {
                Console.WriteLine(item);
            }
        }

        public void getjobsbysalaryrange(decimal minsalary, decimal maxsalary)
        {
            List<Jobs> job2 = _jobRepository.getjobsbysalaryrange(minsalary, maxsalary);
            foreach(Jobs item in job2)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void  insertjobs(Jobs job)
        {
            int insertstatus = _jobRepository.insertjobs(job);
            if (insertstatus > 0)
            {

                Console.WriteLine(insertstatus);
            }
            else
            {
                Console.WriteLine("error in insertion");
            }
        }
    }

}
