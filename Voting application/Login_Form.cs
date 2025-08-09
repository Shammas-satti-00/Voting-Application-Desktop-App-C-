using System;
using System.Data;
using System.Windows.Forms;
using Voting_application.BLL;
using Voting_application.DAL;

namespace Voting_application
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        User_Registration_BLL ub = new User_Registration_BLL();
        User_Registration_DAL ud = new User_Registration_DAL();

        public static class Session
        {
            public static string CurrentUserEmail { get; set; } // Holds logged-in user's email
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text; // Retrieve the password

            try
            {
                // Call the SELECT method to retrieve all user records
                DataTable dt = ud.Select();

                // Filter the DataTable to find the user with the matching email and password
                DataRow[] userRows = dt.Select($"Email = '{email}' AND Password = '{password}'");

                if (userRows.Length > 0) // Check if any matching record is found
                {
                    DataRow user = userRows[0]; // Retrieve the first matching row

                    // Store the email in the session
                    Session.CurrentUserEmail = email;

                    // Check if the user has already voted
                    bool hasVoted = Convert.ToBoolean(user["Voted"]);
                    if (hasVoted)
                    {
                        MessageBox.Show("You have already voted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Navigate to ElectionForm
                        Election_form electionForm = new Election_form();
                        this.Hide();
                        electionForm.Show();
                    }
                }
                else
                {
                    // Show error message on invalid login
                    label5.Text = "Invalid Email or Password.";
                    label5.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing your request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration_Form registerForm = new Registration_Form();
            registerForm.Show(); // Show the Register Form
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
                string username = textBox1.Text.Trim(); // Textbox for username
                string password = textBox2.Text.Trim(); // Textbox for password

                // Call DAL method to verify admin credentials
                bool isAdmin = ud.IsAdminValid(username, password);

                if (isAdmin)
                {
                    MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Admin_form adm = new Admin_form();
                    adm.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid credentials for admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            




            
        }
    
    }
}
