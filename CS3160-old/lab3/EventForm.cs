// Sidney Sanders and Lian Sandoval
// CS 3160 Section 1 Spring 2020
// Lab 3 3/23/2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class EventForm : Form
    {
        private static ListBox eventLst = new ListBox();
        private Event evnt;
  
        // Gets and Sets event List 
        public static ListBox EventLst
        {
            get { return eventLst; }
            set { eventLst = value; }   
        }

        public EventForm()
        {
            InitializeComponent();
        }

        // Adds event to list, checking if all inputs are given/valid
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                int year = mthCal.SelectionRange.Start.Year;
                int day= mthCal.SelectionRange.Start.Day;
                int month = mthCal.SelectionRange.Start.Month;
                int sh = int.Parse(cmbSHour.SelectedItem.ToString());
                int eh = int.Parse(cmbEHour.SelectedItem.ToString());
                int sm = int.Parse(cmbSMinute.SelectedItem.ToString());
                int em = int.Parse(cmbEMinute.SelectedItem.ToString());
                bool found = false;
                string title = txtEvent.Text.ToString();

                // converts to military time
                if (cmbSAMPM.SelectedItem.ToString() == "PM" && cmbSHour.SelectedItem.ToString() != "12")
                {
                    sh = sh + 12;
                }
                else if (cmbSAMPM.SelectedItem.ToString() == "AM" && cmbSHour.SelectedItem.ToString() == "12")
                {
                    sh = 0;
                }
                

                if (cmbEAMPM.SelectedItem.ToString() == "PM" && cmbEHour.SelectedItem.ToString() != "12")
                {
                    eh = eh + 12;
                }
                else if (cmbEAMPM.SelectedItem.ToString() == "AM" && cmbEHour.SelectedItem.ToString() == "12")
                {
                    eh = 0;
                }


                evnt = new Event(month, day, year, sh, sm, eh, em, title);

                // checks to see if there are any time constraints (if start times and event names are equal)
                foreach (Event search in EventLst.Items)
                {

                    if (search.Equals(evnt))
                    {
                        found = true;
                    }
                }
                if (found == false)
                {

                    EventLst.Items.Add(evnt);
                    this.Close();
                }
                else
                {
                    throw new Exception("Time Constraint: you have another event at this time");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        // Loads EventForm with defaults and calendar constraints 
        private void EventForm_Load(object sender, EventArgs e)
        {
            DateTime max_date = new DateTime(2020, 12, 31, 11, 59, 59);
            mthCal.MinDate = DateTime.Today;
            mthCal.SelectionRange.Start = mthCal.TodayDate;
            mthCal.SelectionRange.End = max_date;
            cmbSHour.SelectedItem = "12";
            cmbSMinute.SelectedItem = "00";
            cmbSAMPM.SelectedItem = "AM";
            cmbEHour.SelectedItem = "12";
            cmbEMinute.SelectedItem = "00";
            cmbEAMPM.SelectedItem = "PM";

            
        }
    }
}
