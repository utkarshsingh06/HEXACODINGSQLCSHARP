using CareerHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Repository.Interfaces
{
    internal interface IApplicationsRepository
    {
        public int insertApplications(Applications applications);
        public List<Applications> GetApplications();
    }
}
