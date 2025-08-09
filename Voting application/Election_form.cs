using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static Voting_application.Login_Form;
using Voting_application.BLL;
using Voting_application.DAL;

namespace Voting_application
{
    public partial class Election_form : Form
    {
        public Election_form()
        {
            InitializeComponent();
        }
        User_Registration_BLL ub=new User_Registration_BLL();
        User_Registration_DAL ud=new User_Registration_DAL();

        private void label2_Click(object sender, EventArgs e)
        {
            // Label click handler if needed
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedCandidate = "";
            foreach (RadioButton rb in groupBox2.Controls)
            {
                if (rb.Checked)
                {
                    selectedCandidate = rb.Text; // Store the selected candidate's name
                    break;
                }
            }

            if (string.IsNullOrEmpty(selectedCandidate))
            {
                MessageBox.Show("Please select a candidate before casting your vote.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve the logged-in user's email from the session
            ub.Email = Login_Form.Session.CurrentUserEmail;
            if (string.IsNullOrEmpty(ub.Email))
            {
                MessageBox.Show("User email is not set. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear all candidate properties in the BLL object
            ub.Candidate1 = ub.Candidate2 = ub.Candidate3 = ub.Candidate4 = null;

            // Assign the selected candidate to the corresponding property in the BLL object
            if (selectedCandidate == "Candidate1")
                ub.Candidate1 = selectedCandidate;
            else if (selectedCandidate == "Candidate2")
                ub.Candidate2 = selectedCandidate;
            else if (selectedCandidate == "Candidate3")
                ub.Candidate3 = selectedCandidate;
            else if (selectedCandidate == "Candidate4")
                ub.Candidate4 = selectedCandidate;

            // Call the UPDATE method to save changes
            bool success = ud.UPDATE(ub);
            if (success)
            {
                MessageBox.Show("Vote successfully submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label5.Text = "Vote casted successfully!";
                label5.ForeColor = Color.Green;
                label5.Visible = true;
            }
            else
            {
                MessageBox.Show("An error occurred while submitting your vote.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Login_Form LoginForm = new Login_Form();
            LoginForm.Show();
            this.Hide();
        }
    }
}
