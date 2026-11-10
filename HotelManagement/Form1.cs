using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{

    public enum UserAdmin
    {
        Booking,
        Managing
    }
    

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
             
        }

        private void btn_regis_Click(object sender, EventArgs e)
        {
            new ChoosingFormNew(UserAdmin.Booking).Show();

        }

        private void btn_manag_Click(object sender, EventArgs e)
        {
            if(txtbox_nickname.Text == "admin")
            {
                if(txtbox_password.Text == "Hoteldemo")
                {
                    new ChoosingFormNew(UserAdmin.Managing).Show();
                }
            }
            
        }
    }
}
