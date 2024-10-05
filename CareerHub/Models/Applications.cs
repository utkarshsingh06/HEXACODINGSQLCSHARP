using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Models
{
    internal class Applications
    {
        public int ApplicationID { get; set; } 
        public int JobID { get; set; } 
        public int ApplicantID { get; set; } 
        public DateTime ApplicationDate { get; set; } 
        public string CoverLetter { get; set; } 
        public Applications(int applicationID, int jobID, int applicantID, DateTime applicationDate, string coverLetter)
        {
            ApplicationID = applicationID;
            JobID = jobID;
            ApplicantID = applicantID;
            ApplicationDate = applicationDate;
            CoverLetter = coverLetter;
        }

        // Default constructor
        public Applications()
        {
        }
        public override string ToString()
        {
            return $"Application ID: {ApplicationID}, Job ID: {JobID}, Applicant ID: {ApplicantID}, " +
                   $"Date: {ApplicationDate}, Cover Letter: {CoverLetter}";
        }
    }
}
