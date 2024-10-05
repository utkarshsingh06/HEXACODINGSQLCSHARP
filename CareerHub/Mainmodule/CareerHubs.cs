using CareerHub.Models;
using CareerHub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CareerHub.Mainmodule
{
    internal class CareerHubs
    {
        private readonly IJobsservices _jobsservices;
        private readonly ICompanyservice _companyservice;
        private readonly IApplicationsService _applicationsService;
        private readonly IAppplicantService _appplicantService;
        public CareerHubs(IJobsservices jobsservices,ICompanyservice companyservice,IApplicationsService applicationsService,IAppplicantService appplicantService)
        {
            _jobsservices = jobsservices;
            _companyservice = companyservice;
            _applicationsService = applicationsService;
            _appplicantService = appplicantService;

        }

        public void showMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("-------------Career Hub----------");
                Console.WriteLine("1. Job listing Retrieval");
                Console.WriteLine("2. Application Profile Creation");
                Console.WriteLine("3. Job Application Submission");
                Console.WriteLine("4. Company Job Posting");
                Console.WriteLine("5. Salary Range Query");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        joblistingretrieveal();

                        break;
                    case "2":
                        applicantprofile();
                        break;

                        break;
                    case "3":
                        applicationsubmisson();
                        break;

                        break;
                    case "4":
                        companyjobposting();
                        break;

                        break;
                    case "5":
                        salaryrangequery();
                        break;
                    case "6":
                        Console.WriteLine("Exiting");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            void joblistingretrieveal()
            {
                Console.WriteLine("Showing the Lis of all jobs: ");
                _jobsservices.GetJobs();
            }
            void applicantprofile()
            {
                Applicants applicant = new Applicants();
                Console.WriteLine("Enter Applicant First Name:");
                applicant.FirstName = Console.ReadLine();

                Console.WriteLine("Enter Applicant Last Name:");
                applicant.LastName = Console.ReadLine();

                Console.WriteLine("Enter Applicant Email:");
                applicant.Email = Console.ReadLine();

                Console.WriteLine("Enter Applicant Phone Number:");
                applicant.Phone = Console.ReadLine();

                Console.WriteLine("Enter Applicant Resume ");
                applicant.Resume = Console.ReadLine();

                _appplicantService.CreateProfile(applicant);
                
            }
            void applicationsubmisson()
            {
                Applications applications = new Applications();
                Console.WriteLine("Enter your Applicant ID:");
                int applicantID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Job ID you want to apply for:");
                int jobID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your Cover Letter:");
                string coverLetter = Console.ReadLine();
                Applications application = new Applications
                {
                    ApplicantID = applicantID,
                    JobID = jobID,
                    CoverLetter = coverLetter,
                    ApplicationDate = DateTime.Now
                };
                int res=_applicationsService.insertApplications(application);
                Console.WriteLine(res);
            }
            void companyjobposting(){

            }
            void salaryrangequery()
            {
                Console.WriteLine("enter salary range start: ");
                int minsalary=int.Parse(Console.ReadLine());
                int maxsalary=int .Parse(Console.ReadLine());
                Console.WriteLine("enetr salary range end");
                _jobsservices.getjobsbysalaryrange(minsalary, maxsalary);
            }


        }
    }
}
