using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Models
{
    internal class Company
    {
        public int CompanyID { get; set; } 
        public string CompanyName { get; set; } 
        public string Location { get; set; }
        public Company(int companyID, string companyName, string location)
        {
            CompanyID = companyID;
            CompanyName = companyName;
            Location = location;
        }
        public Company()
        {
        }
        public override string ToString()
        {
            return $"Company ID: {CompanyID}, Name: {CompanyName}, Location: {Location}";
        }

    }
}
