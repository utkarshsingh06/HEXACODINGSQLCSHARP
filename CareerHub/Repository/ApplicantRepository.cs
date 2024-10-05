using CareerHub.Models;
using CareerHub.Repository.Interfaces;
using CareerHub.Services;
using CareerHub.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerHub.Repository
{
    internal class ApplicantRepository : IApplicantRepository
    {


        SqlCommand cmd = null;
        public ApplicantRepository()
        {
            cmd = new SqlCommand();
        }
        public void ApplyForJob(int jobID, string coverLetter)
        {
            throw new NotImplementedException();
        }

        public int CreateProfile(Applicants applicant)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DbConutil.GetConnString()))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlConnection;
                        cmd.CommandText = "UPDATE Applicants SET email = @Email, first_name = @FirstName, last_name = @LastName, phone = @Phone,Resumes=@reusme,years_of_experience=@yoe,city=@City,state=@State WHERE ApplicantID = @ApplicantID";
                        cmd.Parameters.AddWithValue("@Email", applicant.Email);
                        cmd.Parameters.AddWithValue("@FirstName", applicant.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", applicant.LastName);
                        cmd.Parameters.AddWithValue("@Phone", applicant.Phone);
                        cmd.Parameters.AddWithValue("@ApplicantID", applicant.ApplicantID);
                        cmd.Parameters.AddWithValue("@Resume", applicant.Resume);
                        cmd.Parameters.AddWithValue("@City", applicant.City);
                        cmd.Parameters.AddWithValue("@State", applicant.State);

                        cmd.Connection = sqlConnection;
                        sqlConnection.Open();
                        int updatestatus = cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                        return updatestatus;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"An error occurred while updating the profile: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }
        }

        public List<Applicants> GetApplicants()
        {
            throw new NotImplementedException();
        }

        public int insertapplicant(Applicants applicant)
        {
                using (SqlConnection sqlConnection = new SqlConnection(DbConutil.GetConnString()))
                {
                    string query = "INSERT INTO Applicants VALUES (@FirstName, @LastName, @Email, @Phone, @Resume,@year_of_exp,@city,@state)";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", applicant.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", applicant.LastName);
                        cmd.Parameters.AddWithValue("@Email", applicant.Email);
                        cmd.Parameters.AddWithValue("@Phone", applicant.Phone);
                        cmd.Parameters.AddWithValue("@Resume", applicant.Resume);
                        cmd.Parameters.AddWithValue("@year_of_exp", applicant.Yoe);
                        cmd.Parameters.AddWithValue("@city", applicant.City);
                        cmd.Parameters.AddWithValue("@state", applicant.State);

                    
                            sqlConnection.Open();
                            int intsertstatus=cmd.ExecuteNonQuery();
                            sqlConnection.Close();
                    return intsertstatus;
                            
                        
                    }
                }
        }
    }
}
