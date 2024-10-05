using CareerHub.Repository.Interfaces;
using CareerHub.Repository;
using CareerHub.Services;
using CareerHub.Mainmodule;

namespace CareerHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IJobRepository jobrepository=new JobRepository();
            IJobsservices jobsservices=new JobsService(jobrepository);

            ICompanyRepositoy companyrepositoy = new CompanyRepository();
            ICompanyservice companyservice = new CompanyService(companyrepositoy);

            IApplicantRepository applicantRepository = new ApplicantRepository();
            IAppplicantService appplicantService =new ApplicantService(applicantRepository);


            IApplicationsRepository applicationsRepository=new ApplicationsRepository();
            IApplicationsService applicationsService=new ApplicationsService(applicationsRepository);



            CareerHubs cb = new CareerHubs(jobsservices);
            cb.showMenu();
        }
    }
}
