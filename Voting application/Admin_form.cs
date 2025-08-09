using System;
using System.Data;
using System.Windows.Forms;
using Voting_application.DAL;

namespace Voting_application
{
    public partial class Admin_form : Form
    {
        public Admin_form()
        {
            InitializeComponent();
        }

        // Instance of the DAL class for database interaction
        User_Registration_DAL userDAL = new User_Registration_DAL();

        // Event handler for form load
        private void Admin_form_Load(object sender, EventArgs e)
        {

        }

        // Method to load registered users from the database using DAL
        private void LoadUsers()
        {
            try
            {
                // MessageBox.Show("LoadUsers called"); // Debug log
                DataTable usersTable = userDAL.GetAllUsers();
                //MessageBox.Show("Rows in Users Table: " + usersTable.Rows.Count);
                if (usersTable.Rows.Count == 0)
                {
                    MessageBox.Show("No users found in the database.");
                }
                else
                {
                    dataGridView1.DataSource = null; // Clear previous binding
                    dataGridView1.DataSource = usersTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        // Method to load vote counts from the database using DAL
        private void LoadVotes()
        {
            try
            {
                DataTable votesTable = userDAL.GetAllVotes(); // Retrieve vote data from DAL
                if (votesTable.Rows.Count == 0)
                {
                    MessageBox.Show("No vote data found in the database.");
                }
                else
                {
                    dataGridView2.DataSource = null; // Clear any existing bindings
                    dataGridView2.DataSource = votesTable;
                    // Bind data to the DataGridView for votes

                    //    MessageBox.Show("Votes Retrieved: " + votesTable.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }

        }

        // Event handler for TabControl index change
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Tab 1: Users
            {
                LoadUsers();
            }
            else if (tabControl1.SelectedIndex == 1) // Tab 2: Votes
            {
                LoadVotes();
            }
        }

        // Event handler for logout button
        private void button1_Click(object sender, EventArgs e)
        {
            Login_Form LoginForm = new Login_Form();
            LoginForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_form_Load_1(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView2.AutoGenerateColumns = true;


            LoadUsers(); // Load the users data into the DataGridView
            LoadVotes(); // Load the votes data into the DataGridView

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
