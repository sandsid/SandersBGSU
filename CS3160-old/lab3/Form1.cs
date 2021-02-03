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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Loads form, sets button to false
        private void Form1_Load(object sender, EventArgs e)
        {
            EventForm.EventLst = lstDates;
            btnDelete.Enabled = false;
        }

        // Opens EventForm to allow user Event input
        private void btnNew_Click(object sender, EventArgs e)
        {

                try
                {
                    using(EventForm e_f = new EventForm())
                    {
                        if (e_f.ShowDialog() == DialogResult.OK)
                        {
                            lstDates = EventForm.EventLst;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        // Allows user to select event, fills text boxes with appropriate data
        private void lstDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            Event new_event = (Event)lstDates.SelectedItem;

            if(new_event != null)
            {
                DateTime start = new_event.get_start();
                DateTime end = new_event.get_end();

                txtEventDetail.Text = ((Event)lstDates.SelectedItem).get_title();
                txtDate.Text = start.ToString();
                txtDay.Text = start.DayOfWeek.ToString();

                txtTime.Text = start.ToString("hh:mm tt") + " to " + end.ToString("hh:mm tt");
            }
        
        }

        // Deletes selected event from text box
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstDates.Items.Remove(lstDates.SelectedItem);
            txtDate.Clear();
            txtDay.Clear();
            txtEventDetail.Clear();
            txtTime.Clear();
            btnDelete.Enabled = false;
        }
    }
}
