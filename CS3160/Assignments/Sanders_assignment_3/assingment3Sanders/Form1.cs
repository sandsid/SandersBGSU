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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Form loads with the list loaded and defaults.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2.EventList = lstEvents;
            btnDelete.Enabled = false;
        }


        /// <summary>
        /// New button click to open the Form2 and catch any error
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            //try to create a new event catch the error if something fails
            try
            {
                using (Form2 eventForm = new Form2())
                {
                    if (eventForm.ShowDialog() == DialogResult.OK)
                        lstEvents = Form2.EventList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Delete button to remove a event from the list box and clear all text boxes.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstEvents.Items.Remove(lstEvents.SelectedItem);
            txtDate.Clear();
            txtDay.Clear();
            txtEventDets.Clear();
            txtTime.Clear();
            btnDelete.Enabled = false;
        }


        /// <summary>
        /// Index change triggers the addition to details to text boxes on the form.
        /// </summary>
        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            Event selectedEvent = (Event)lstEvents.SelectedItem;

            if(selectedEvent != null)
            {
                DateTime start = selectedEvent.getStart();
                DateTime stop = selectedEvent.getStop();

                txtEventDets.Text = selectedEvent.getTitle();
                txtDate.Text = start.ToString();
                txtDay.Text = start.DayOfWeek.ToString();
                txtTime.Text = start.ToString("hh:mm tt") + " to " + stop.ToString("hh:mm tt");
            }
        }
    }
}
