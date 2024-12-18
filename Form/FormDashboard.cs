using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hotel_management
{
    public partial class FormDashboard : Form
    {
        public string Username;

        public FormDashboard()
        {
            InitializeComponent();
            userControlDashbord1.User();
            userControlDashbord1.Client();
            userControlDashbord1.Room();
            userControlDashbord1.Show();
        }

        
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }



        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();  

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            
           // userControlSetting.Clear();
            MovePanel(buttonDashboard);
            userControlSetting3.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlAboutus1.Hide();
            userControlCancellation1.Hide();
            userControlDashbord1.User();
            userControlDashbord1.Client();
            userControlDashbord1.Room();
            userControlDashbord1.Show();

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            userControlSetting3.Hide();
            userControlClient1.Clear();
            userControlClient1.Show();
            userControlRoom1.Hide();
            userControlAboutus1.Hide();
            userControlCancellation1.Hide();
            userControlDashbord1.Hide();

        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            userControlSetting3.Hide();
            userControlClient1.Hide();
            //userControlRoom1.Clear();
            userControlRoom1.Show();
            userControlAboutus1.Hide();
            userControlCancellation1.Hide();
            userControlDashbord1.Hide();

        }

        private void buttonancelation_Click(object sender, EventArgs e)
        {

            
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
           MovePanel(buttonSetting);
           userControlSetting3.Clear();
           userControlSetting3.Show();
           userControlClient1.Hide();
           userControlRoom1.Hide();
            userControlAboutus1.Hide();
            userControlCancellation1.Hide();
            userControlDashbord1.Hide();


        }


        private void userControlSetting1_Load(object sender, EventArgs e)
        {

        }

        private void userControlSetting1_Load_1(object sender, EventArgs e)
        {

        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlSetting2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovePanel(buttonAboutUs);
            //userControlAboutus1.Clear();
            userControlAboutus1.Show();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlSetting3.Hide();
            userControlDashbord1.Hide();
        }

        private void buttonCancelation_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancellation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonCancellation);
            userControlSetting3.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlAboutus1.Hide();
            // userControlCancellation1.clear();
            userControlCancellation1.Show();
            userControlDashbord1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
