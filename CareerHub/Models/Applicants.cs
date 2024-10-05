using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Models
{
    internal class Applicants
    {
        public int ApplicantID { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Email { get; set; } 
        public string Phone { get; set; } 
        public string Resume { get; set; } 
        public Applicants(int applicantID, string firstName, string lastName, string email, string phone, string resume)
        {
            ApplicantID = applicantID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Resume = resume;
        }
        public Applicants()
        {
        }
        public override string ToString()
        {
            return $"Applicant ID: {ApplicantID}, Name: {FirstName} {LastName}, Email: {Email}, Phone: {Phone}, Resume: {Resume}";
        }
    }
}
