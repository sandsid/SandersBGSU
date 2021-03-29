// Sidney Sanders 
// CS 3160 Section 1 Spring 2021
// Assignment 3 -- 3/13/2021

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assingment3Sanders
{
    public partial class Form2: Form
    {
        private static ListBox eventList = new ListBox();
        private Event newEvent;
        
        public static ListBox EventList
        {
            get { return eventList; }
            set { eventList = value; }
        }


        public Form2()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Form2 loads with the set range loaded in and the default values set to a work day.
        /// </summary>
        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime maxDate = new DateTime(2021, 12, 31, 11, 59, 59);
            calendar.MinDate = DateTime.Today;
            cboStartH.SelectedItem = "08";
            cboStartM.SelectedItem = "00";
            cboStopH.SelectedItem = "17";
            cboStopM.SelectedItem = "00"; 
        }


        /// <summary>
        /// Add button checks if Event details are filled and then exicutes the event variffication.
        /// Checks if there is a duplicate event, if no error, adds to list of events on Form1.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEventTitle.Text != "")
                {
                    int year = calendar.SelectionRange.Start.Year;
                    int month = calendar.SelectionRange.Start.Month;
                    int day = calendar.SelectionRange.Start.Day;
                    int startH = int.Parse(cboStartH.SelectedItem.ToString());
                    int startM = int.Parse(cboStartM.SelectedItem.ToString());
                    int stopH = int.Parse(cboStopH.SelectedItem.ToString());
                    int stopM = int.Parse(cboStopM.SelectedItem.ToString());
                    string title = txtEventTitle.Text.ToString();

                    newEvent = new Event(month, day, year, startH, startM, stopH, stopM, title);
                    
                    if(startH > stopH)
                        throw new Exception("Event can not start after it ends.");

                    bool match = false;
                    foreach (Event otherEvent in eventList.Items)
                    {
                        if (otherEvent.Equals(newEvent))
                            match = true;
                    }

                    if (match == false)
                    {
                        EventList.Items.Add(newEvent);
                        this.Close();
                    }
                    else
                        throw new Exception("Another event already exsists at this time.");
                    
                }
                else
                    throw new Exception("Description cannot be empty!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        /// <summary>
        /// Cancel will not send any data to the EventList and closes Form2.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
