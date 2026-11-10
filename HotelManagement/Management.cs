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
    public partial class Management : UserControl 
    {
        public string pathx = @"BookingData.txt";
        
        public Management()
        {
            
            InitializeComponent();

        }
         DataTable xbookingtable = new DataTable();
        private void Management_Load(object sender, EventArgs e)
        {
            xbookingtable.Columns.Add("Booker Id", typeof(string));
            xbookingtable.Columns.Add("Name", typeof(string));
            xbookingtable.Columns.Add("Surname", typeof(string));
            xbookingtable.Columns.Add("Age", typeof(string));
            xbookingtable.Columns.Add("Phone number", typeof(string));
            xbookingtable.Columns.Add("Date from", typeof(string));
            xbookingtable.Columns.Add("Date to", typeof(string));
            xbookingtable.Columns.Add("Guests", typeof(string));
            xbookingtable.Columns.Add("Room type", typeof(string));
            xbookingtable.Columns.Add("Booked time", typeof (string));

            dataGridView1.DataSource = xbookingtable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // The file is created when the first booking is saved.
            if (!File.Exists(pathx))
            {
                MessageBox.Show("No bookings have been saved yet.");
                return;
            }

            xbookingtable.Rows.Clear();
            string[] lines = File.ReadAllLines(pathx);
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                xbookingtable.Rows.Add(row);
            }

        }
    }
}
