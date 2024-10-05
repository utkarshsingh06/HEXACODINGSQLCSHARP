using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerHub.Models;

namespace CareerHub.Repository.Interfaces
{
    internal interface ICompanyRepositoy
    {
        void PostJob(string jobTitle, string jobDescription, string jobLocation, decimal salary, string jobType);
        List<Company> GetCompanies();
        public int insertcompnay(Company company);
    }
}
