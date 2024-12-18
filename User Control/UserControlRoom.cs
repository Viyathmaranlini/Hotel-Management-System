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
    //SqlConnection connection;
    //private string No = "", Free = "";
   // public UserControlRoom()
    public partial class UserControlRoom : UserControl
    {
        public UserControlRoom()
        {
            InitializeComponent();
            string connectionString = ("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");
            //String connectionString = ("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");
            //connection = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");

        }
        SqlConnection Conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");

        public void Clear()
        {
            textroomno.Clear();
            textBoxphoner.Clear();
           


        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddr_Click(object sender, EventArgs e)
        {
            string  Free = "   ";
            if (radioButtony.Checked)
                Free = "Y";
            if (radioButtonn.Checked)
                Free = "N";
            bool check;
            if (comboBoxrm.SelectedIndex == -1 || textBoxphoner.Text.Trim() == string.Empty || Free == "")

                MessageBox.Show("Please fill out the feilds.", "Require all feild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Conn.Open();

                int @rmid = Convert.ToInt32(textroomno.Text);
                //string @rtype = Convert.ToString (comboBoxrm.Text);
                //string @rtype = comboBoxrm.SelectedItem.ToString();
                string @rtype = Convert.ToString(comboBoxrm.SelectedItem);
                string @free = Free;
                //string @free = Convert.ToString(Free);
                string @phnr = textBoxphoner.Text;
                // Prepare the SQL query to add if the username and password exist

                string query = $"INSERT INTO Room_Table (Room_Number,Room_type,Room_Phone,Room_free) VALUES ( ' " + @rmid + " ', ' " + @rtype + "' , '" + @phnr + "', ' " + @free + " ' )";
                //string query = $"INSERT INTO Room_Table (Room_Number,Room_type,Room_Phone,Room_free) VALUES ( ' " + @rmid + " ', ' " + "eeeee" + "' , '" + @free + "', ' " + @phnr + " ' )";

                // Create and configure a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {


                    cmd.ExecuteNonQuery();

                    // Close the connection

                    Conn.Close();

                }


                //check = connection.AddRoom(comboBoxType.SelectedItem.ToString, textBoxPhoneNo.Text.Trim(), textBoxPhoneNo.Text.Trim(), Free);
               // if (check)
                    Clear();
            }
        }

        private void textBoxphoner_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
