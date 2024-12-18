using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel_management.User_Control
{
    public partial class UserControlCancellation : UserControl
    {
        private string ID = "";
        public UserControlCancellation()
        {
            InitializeComponent();
            string connectionString = ("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");

        }
        SqlConnection Conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");



        private void buttonCancel_Click(object sender, EventArgs e)
        {

            bool check;
            //if (ID != "")
            //{
                if (textBoxUsernamecC.Text.Trim() == string.Empty)
                    MessageBox.Show("Please fill out the feilds.", "Require reservation id feild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Are you want to cancel the reservation?", " Cancel ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        //cheak = db.DeleteUser(ID);
                        // Open the connection
                        Conn.Open();


                        string @Rid = textBoxUsernamecC.Text;
                    //string @Pname = textBoxPassword.Text;
                    //string @Uid = textBoxUserId.Text;

                    // Prepare the SQL query to add if the username and password exist

                    //string query = $"INSERT INTO User_Table (User_ID,User_Name,User_Password) VALUES (  ' " + @Uid + "',' " + @Uname + " ', ' " + @Pname + "' )";
                    string query = $"DELETE FROM Resevation_Table WHERE Res_ID = '" + @Rid + "' ";


                    // Create and configure a SqlCommand object
                     using (SqlCommand cmd = new SqlCommand(query, Conn))
                    {

                        cmd.ExecuteScalar();
                        // cmd.ExecuteNonQuery();

                        // Close the connection

                        Conn.Close();

                        }
                        // if (cheak)
                        //   Clear1();
                    }
               // }
            }
        }    
            
            
           



      
    }
}
