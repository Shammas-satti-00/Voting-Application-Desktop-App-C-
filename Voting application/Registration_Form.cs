using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;
using Voting_application.BLL;
using Voting_application.DAL;

namespace Voting_application
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }
        User_Registration_BLL ub = new User_Registration_BLL();
        User_Registration_DAL ud = new User_Registration_DAL();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           ub.Name = textBox1.Text;
           ub.Email= textBox2.Text;
           ub.Password= textBox3.Text;
           ub.Unique_ID = Guid.NewGuid().ToString(); // Generate a new GUID

            //ub.Unique_ID = textBox4.Text;

            bool success = ud.INSERT(ub);
            if (success == true)
            {
                MessageBox.Show("user added sucessfully");
            }
            else
            {
                MessageBox.Show("failed to add new user");
            }





            //string name = textBox1.Text;
           // string email = textBox2.Text;
            //string password = textBox3.Text;
            //string uniqueID = textBox4.Text;

           // using (SqlConnection conn = new SqlConnection("Server=DESKTOP-9JC5T7A\\SQLEXPRESS;Database=Votingapp;Integrated Security=True;"))

           // {
              //  conn.Open();
              //  SqlCommand cmd = new SqlCommand("INSERT INTO User (Name, Email, Password, UniqueId, Voted) VALUES (@Name, @Email, @Password, @Unique_ID, 0)", conn);
               // cmd.Parameters.AddWithValue("@Name", name);
             //   cmd.Parameters.AddWithValue("@Email", email);
             //   cmd.Parameters.AddWithValue("@Password", password);
             //   cmd.Parameters.AddWithValue("@Unique_ID", uniqueID);
             //
             // //  try
             //   {
               //     cmd.ExecuteNonQuery();
                 //   MessageBox.Show("Registration successful!");
                    // Redirect to LoginForm
                 //   Login_Form loginForm = new Login_Form();
                //    this.Hide();
                //    loginForm.Show();
             //   }
               // catch (SqlException ex)
               // {
              //      MessageBox.Show("Error: " + ex.Message);
              //  }
           // }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_Form LoginForm = new Login_Form();
            LoginForm.Show();
            this.Hide();

        }
    }
}
