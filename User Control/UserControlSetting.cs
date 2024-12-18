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
    public partial class UserControlSetting : UserControl
    {
        
        
        SqlConnection connection;
        private string ID = "";

        public UserControlSetting()
        {
            InitializeComponent();

           

            string connectionString = ("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");
           // connection = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");

        }
        SqlConnection Conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=hotel_management;Integrated Security=True");





        private void label5_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {


                //Conn.DisplayAndSearch("SELECT * FROM User_Table WHERE User_Name LIKE '%" + textBoxSearchUsername.Text + "%", dataGridViewUser);
            }


            public void Clear()
            {
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                tabControlUser.SelectedTab = tabPageAddUser;
                textBoxUserId.Clear();

            }

            private void Clear1()
            {
                textBoxUsername1.Clear();
                textBoxPassword2.Clear();
                ID = "";
            }

            private void tabPageAddUser_Leave(object sender, EventArgs e)
            {
                Clear();
                Clear();
            }

            private void tabPageSearchUser_Enter(object sender, EventArgs e)
            {
                

                //conn.DisplayAndSearch("SELECT * FROM User_Table", dataGridViewUser);
            }

            private void tabPageSearchUser_Leave(object sender, EventArgs e)
            {
                textBoxUsername.Clear();
            }

            private void tabPageUpdateandDeleteUser_Leave(object sender, EventArgs e)
            {
                Clear1();
            }

            private void buttonAdd_Click(object sender, EventArgs e)
            {


                bool check;
                if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
                    MessageBox.Show("Please fill out the feilds.", "Require all feild", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                // Open the connection
                Conn.Open();

                
                string @Uname = textBoxUsername.Text;
                string @Pname = textBoxPassword.Text;
                string @Uid = textBoxUserId.Text;

                // Prepare the SQL query to add if the username and password exist

                string query = $"INSERT INTO User_Table (User_ID,User_Name,User_Password) VALUES (  ' " + @Uid + "',' " + @Uname + " ', ' " + @Pname + "' )";


                // Create and configure a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {


                    cmd.ExecuteNonQuery();

                    // Close the connection

                    Conn.Close();

                }



                //check = connection.AddUser(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
                //if (check)
                 Clear();
            }
        }

            private void buttonUpdate_Click(object sender, EventArgs e)
            {
                bool check;
                if (ID != "")
                {
                    if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword2.Text.Trim() == string.Empty)
                        MessageBox.Show("Please fill out the feilds.", "Require all feild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        //cheak = .UpdateUser(ID, textBoxUsername1.Text.Trim(), textBoxPassword2.Text.Trim());
                        //if (cheak)
                          //  Clear1();
                    }

                }
                else
                    MessageBox.Show("Please fist select row from table.", "Selection of row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                    ID = row.Cells[0].Value.ToString();
                    textBoxUsername1.Text = row.Cells[1].Value.ToString();
                    textBoxPassword2.Text = row.Cells[2].Value.ToString();

                }
            }

            private void buttonDelete_Click(object sender, EventArgs e)
            {
                bool check;
                if (ID != "")
                {
                    if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword2.Text.Trim() == string.Empty)
                        MessageBox.Show("Please fill out the feilds.", "Require all feild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you want to delete the user?", "User delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == result)
                        {
                            //cheak = db.DeleteUser(ID);

                           // if (cheak)
                             //   Clear1();
                        }
                    }

                }
                else
                    MessageBox.Show("Please fist select row from table.", "Selection of row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void UserControlSetting_Load(object sender, EventArgs e)
            {

            }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPageAddUser_Click(object sender, EventArgs e)
        {

        }
    } 
}
