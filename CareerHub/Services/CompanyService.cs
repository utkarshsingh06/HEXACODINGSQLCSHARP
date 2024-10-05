using CareerHub.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Services
{
    internal class CompanyService
    {
        readonly ICompanyRepositoy _companyRepositoy;

        public CompanyService(ICompanyRepositoy companyRepositoy)
        {
            _companyRepositoy = companyRepositoy;
        }
    }
}
