using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w6_inclass1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpCalendar.MinDate = DateTime.Today;
            dtpCalendar.MaxDate = DateTime.Today.AddYears(1);
            dtpCalendar.CalendarForeColor = Color.Aqua;
            dtpCalendar.CalendarMonthBackground = Color.Black;

        }

        private void dtpCalendar_ValueChanged(object sender, EventArgs e)
        {
            

            DateTime dropOff = dtpCalendar.Value;
            if(dropOff.DayOfWeek == DayOfWeek.Saturday || dropOff.DayOfWeek == DayOfWeek.Sunday)
            {
                txtEstimate.Text = dropOff.AddDays(3).ToLongDateString();
            }
            else
            {
                txtEstimate.Text = dropOff.AddDays(2).ToLongDateString();
            }
        }
    }
}
