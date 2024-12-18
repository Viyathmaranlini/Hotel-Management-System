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
    public partial class UserControlClient : UserControl
    {
       // SqlConnection connection;
        private string ID = "";
        public UserControlClient()
        {
            InitializeComponent();
            string connectionString = ("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");
           // connection = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");
           
        }
        SqlConnection Conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");
        public void Clear()
        {
            textBoxClientID.Clear();
            textBoxFistName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNo.Clear();
            textBoxAddress.Clear();
            tabControlClient.SelectTab(tabPageAddclient);


        }

        private void Clear1()
        {
            textBoxFistName1.Clear();
            textBoxLastName1.Clear();
            textBoxPhoneNo1.Clear();
            textBoxAddress1.Clear();
            ID = "";


        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxFistName.Text.Trim() == string.Empty || textBoxLastName.Text.Trim() == string.Empty ||
                textBoxPhoneNo.Text.Trim() == string.Empty || textBoxAddress.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill out the feilds.", "Require all feild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                // Open the connection
                Conn.Open();

                int @clid = Convert.ToInt32(textBoxClientID.Text);
                string @fname = textBoxFistName.Text;
                string @lname = textBoxLastName.Text;
                string @add   = textBoxAddress.Text;
                string @phon =   textBoxPhoneNo.Text;
                // Prepare the SQL query to add if the username and password exist

                string query = $"INSERT INTO Client_Table (Client_ID,Client_FistName,Client_LastName,Client_Phone,Client_Address) VALUES ( ' " + @clid + " ', ' " + @fname + "' , '" + @lname + "', ' " + @phon + " '  , '" + @add + "')";
                

                // Create and configure a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {
                  
                  
                    cmd.ExecuteNonQuery();

                    // Close the connection

                    Conn.Close();

                }
                    //  check = SqlConnection.a(textBoxFistName.Text.Trim(), textBoxLastName.Text.Trim(), textBoxPhoneNo.Text.Trim(), textBoxAddress.Text.Trim());
                    //  if (check)
                         Clear();
                }
            }

        private void buttonAdd_Leave(object sender, EventArgs e)
        {

        }

        private void tabPageAddclient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void textBoxFistName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
