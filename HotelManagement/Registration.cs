using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace HotelManagement
{
    public partial class Registration : UserControl
    {
        public string name;
        public string surname;
        public string age;
        public string number;
        public string from;
        public string to;
        public string guests;
        public string roomtype;
        public int randomnumber;
        public string timeString;
        public string path = @"BookingData.txt";

        public Registration()
        {
            
            InitializeComponent();
            for (int i = 1; i < 6; i++)
            {
                combob_guests.Items.Add(i);
            }
            combob_roomtype.Items.Add("Single");
            combob_roomtype.Items.Add("Double");
            for (int i = 18; i < 100; i++)
            {
                cbox_age.Items.Add(i);
            }

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            
                try
                {
                    Random rnd = new Random();
                    randomnumber = rnd.Next(100000, 999999);
                    name = tbox_name.Text;
                    surname = tbox_surname.Text;
                    age = cbox_age.SelectedItem.ToString();
                    number = tbox_phone.Text;
                    from = date_from.Text;
                    to = date_to.Text;
                    guests = combob_guests.SelectedItem.ToString();
                    roomtype = combob_roomtype.SelectedItem.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Please fill all the information");
                }

            DateTime currentTime = DateTime.Now;
            timeString = currentTime.ToString("yyyy-MM-dd hh:mm:ss");

            DialogResult dg  = MessageBox.Show("Is the information correct?", "Attention!", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                FillInfoToNotepad();
                MessageBox.Show("Thank you for booking!");
                tbox_name.Clear();
                tbox_surname.Clear();
                cbox_age.SelectedItem = null;
                tbox_phone.Clear();
                date_from.Value = DateTime.Now;
                date_to.Value = DateTime.Now; 
                combob_guests.SelectedItem = null;
                combob_roomtype.SelectedItem = null;
            }
            else if (dg == DialogResult.No)
            {
                return;
            }
        }

        private void FillInfoToNotepad()
        {
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine($"#{randomnumber.ToString()} | {name}  |  {surname}  |  {age}  |  {number}  |  {from}  |  {to}  |  {guests}  |  {roomtype}   |   {timeString}");
            sw.Close();
        }
    }
}
