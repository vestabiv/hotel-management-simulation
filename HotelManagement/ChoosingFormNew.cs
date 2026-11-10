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
    public partial class ChoosingFormNew : Form
    {

        public ChoosingFormNew(UserAdmin choice)
        {
            InitializeComponent();
            UserControl control = null;
            if (choice == UserAdmin.Booking)
            {
                //load booking
                control = new Registration();
            }
            
            else
            {
                //load managing
                control = new Management();
            }
            var rec = this.ClientRectangle;
            this.Width = control.Width + (this.Width - rec.Width);
            this.Height = control.Height + (this.Height - rec.Height);
            this.Controls.Add(control);
             

        }
    }
}
