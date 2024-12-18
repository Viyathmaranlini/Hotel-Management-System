using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;
using System.Data.SqlClient;
 

namespace hotel_management
{
    public partial class FormLogIn : System.Windows.Forms.Form
    {
        //DbConnector db;
        public FormLogIn()
        {
            InitializeComponent();
           
         
        }
        SqlConnection conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            text_Password.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            text_Password.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (text_Username.Text.Trim() == string.Empty || text_Password.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fill out all fields.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Open the connection
            conn.Open();

            // Prepare the SQL query to check if the username and password exist
            string query = $"SELECT COUNT(*) FROM User_Table WHERE User_Name = @User_Name AND User_Password = @User_Password";

            // Create and configure a SqlCommand object
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@User_Name", text_Username.Text.Trim());
                cmd.Parameters.AddWithValue("@User_Password", text_Password.Text.Trim());

                // Execute the query
                int count = (int)cmd.ExecuteScalar();

                // Close the connection
                conn.Close();

                // Check if there is a matching user in the database
                if (count > 0)
                {
                    // Successful login
                    FormDashboard fd = new FormDashboard();
                    fd.Username = text_Username.Text;
                    text_Username.Clear();
                    text_Password.Clear();
                    fd.Show();
                }
                else
                {
                    // Invalid login
                    MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //bool check = conn.IsValidNamePass(text_Username.Text.Trim(), text_Password.Text.Trim()); 
            //if (text_Username.Text.Trim() == string.Empty || text_Password.Text.Trim() == string.Empty)
            //    MessageBox.Show("Fill out all field.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //{
            //    if (check)
            //    {
            //        FormDashboard fd = new FormDashboard();
            //        fd.Username = text_Username.Text;
            //        text_Username.Clear();
            //        text_Password.Clear();
            //        fd.Show();
            //    }
            //    else
            //        MessageBox.Show("Invalid Username or Passwoed", "Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //string User_Name, User_Password, User_ID;

            //User_Name = text_Username.Text;
            //User_Password = text_Password.Text;

            //try
            //{
            //    string querry = "SELECT* FROM User_Table WHERE User_Name ='" + text_Username.Text + "'AND User_Password ='" + text_Password.Text + "'";
            //    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            //    DataTable dtable = new DataTable();
            //    sda.Fill(dtable);

            //    if (dtable.Rows.Count > 0)
            //    {
            //        User_Name = text_Username.Text;
            //        User_Password = text_Password.Text;

            //        FormDashboard Form1 = new FormDashboard();
            //        Form1.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid Username or Password", "Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        text_Username.Clear();
            //        text_Password.Clear();

            //        text_Username.Focus();
            //    }

            //}
            //catch
            //{
            //    MessageBox.Show("Error");
            //}


        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
