using CareerHub.Models;
using CareerHub.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Repository
{
    internal class CompanyRepository : ICompanyRepositoy
    {
        public List<Company> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public List<Jobs> Getjobs()
        {
            throw new NotImplementedException();
        }

        public int insertcompnay(Company company)
        {
            throw new NotImplementedException();
        }

        public void PostJob(string jobTitle, string jobDescription, string jobLocation, decimal salary, string jobType)
        {
            throw new NotImplementedException();
        }
    }
}
