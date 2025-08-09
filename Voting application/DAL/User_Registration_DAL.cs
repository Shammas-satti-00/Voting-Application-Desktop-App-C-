using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Voting_application.BLL;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Voting_application.DAL
{
    class User_Registration_DAL
    {
        static string myconnstrng = "Data Source=DESKTOP-9JC5T7A\\SQLEXPRESS;Initial Catalog=Votingapp;Integrated Security=True;";


        #region Select Data from Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM UserDetails";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

        #region Insert Data into Database
        public bool INSERT(User_Registration_BLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO UserDetails(Name, Email, Password, UniqueId, Voted)VALUES(@Name, @Email, @Password, @UniqueId, 0)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", u.Name);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Password", u.Password);
                cmd.Parameters.AddWithValue("@UniqueId", u.Unique_ID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Update Data in Database
        public bool UPDATE(User_Registration_BLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Determine the selected candidate
                    string selectedCandidate = null;
                    if (!string.IsNullOrEmpty(u.Candidate1))
                        selectedCandidate = "Candidate1";
                    else if (!string.IsNullOrEmpty(u.Candidate2))
                        selectedCandidate = "Candidate2";
                    else if (!string.IsNullOrEmpty(u.Candidate3))
                        selectedCandidate = "Candidate3";
                    else if (!string.IsNullOrEmpty(u.Candidate4))
                        selectedCandidate = "Candidate4";

                    if (string.IsNullOrEmpty(selectedCandidate))
                        throw new Exception("No candidate was selected for voting.");

                    // Update the VoteCount for the selected candidate
                    string updateVotesSql = "UPDATE Votes SET VoteCount = VoteCount + 1 WHERE Candidate = @Candidate";
                    SqlCommand updateVotesCmd = new SqlCommand(updateVotesSql, conn, transaction);
                    updateVotesCmd.Parameters.AddWithValue("@Candidate", selectedCandidate);
                    int rowsAffectedVotes = updateVotesCmd.ExecuteNonQuery();

                    if (rowsAffectedVotes == 0)
                        throw new Exception("Failed to update the VoteCount. Ensure the Candidate exists in the Votes table.");

                    // Update the UserDetails table
                    string updateUserSql = "UPDATE UserDetails SET Voted = 1 WHERE Email = @Email";
                    SqlCommand updateUserCmd = new SqlCommand(updateUserSql, conn, transaction);
                    updateUserCmd.Parameters.AddWithValue("@Email", u.Email);
                    int rowsAffectedUserDetails = updateUserCmd.ExecuteNonQuery();

                    if (rowsAffectedUserDetails == 0)
                        throw new Exception("Failed to update UserDetails. Ensure the Email exists in the UserDetails table.");

                    // Commit the transaction
                    transaction.Commit();
                    isSuccess = true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Delete Data from Database
        public bool DELETE(User_Registration_BLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM UserDetails WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Get All Registered Users
        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT * FROM UserDetails";
               // MessageBox.Show("Executing query: " + sql);  // Log the query being executed
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                // Debug: Check rows retrieved
                if (dt.Rows.Count == 0)
                    MessageBox.Show("No user data found in the database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        #endregion

        #region Get All Votes
        public DataTable GetAllVotes()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT Candidate, VoteCount FROM Votes";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        public bool IsAdminValid(string username, string password)
        {
            bool isValid = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT COUNT(1) FROM Admins WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password); // Ensure passwords are hashed in both DB and comparison
                conn.Open();

                int result = (int)cmd.ExecuteScalar();
                isValid = result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isValid;
        }

    }
}
