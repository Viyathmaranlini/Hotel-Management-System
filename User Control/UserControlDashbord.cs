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
    public partial class UserControlDashbord : UserControl
    {
        SqlConnection connection;
        public UserControlDashbord()
        {
            InitializeComponent();
            //string connectionString = ("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");
            //connection = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");
        }
        SqlConnection conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");
        public void User()
        {

            // Open the connection
            conn.Open();
            SqlCommand command  = new SqlCommand ("SELECT COUNT(*) FROM User_Table ",conn);
            

            {
                Int32 result = (Int32)command.ExecuteScalar();
                labelUserCount.Text = result.ToString();
              
                // Close the connection

               

            }
            conn.Close();
        }

        public void Client()
        {

            // Open the connection
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Client_Table ", conn);


            {
                Int32 result = (Int32)command.ExecuteScalar();
                labelClientCount.Text = result.ToString();

                // Close the connection

            }
            conn.Close();
        }


        public void Room()
        {

            // Open the connection
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Room_Table ", conn);


            {
                Int32 result = (Int32)command.ExecuteScalar();
                labelRoomCount.Text = result.ToString();

                // Close the connection

            }
            conn.Close();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
