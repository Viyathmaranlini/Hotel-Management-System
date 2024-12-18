using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management.User_Control
{
    public partial class UserControlAboutus : UserControl
    {
        public UserControlAboutus()
        {
            InitializeComponent();
            this.label2about.Text = "The About Us tab on our hotel management system's web application offers a glimpse into our establishment's \n essence. Within, guests discover our mission to provide unparalleled \n hospitality rooted in our core values of excellence and community engagement. \n Meet our dedicated management team, champions of our commitment to delivering exceptional experiences. \n Explore our array of amenities, from luxurious accommodations to fine dining options, all crafted to exceed expectations. \n Learn about our sustainability efforts, reflecting our dedication to environmental responsibility. \n Delve into our rich history and heritage, steeped in tradition and punctuated by moments of distinction. \n  Connect with us directly through provided contact information, as we eagerly await the opportunity to welcome you into our hotel family.";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
