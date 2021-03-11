using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace bonuslab4
{
    public partial class Form1 : Form
    {

        static bool errorFlag; 
        private PhoneApp app;// business tier object that contains the application logic
        static void Main() 
        {
            try 
            {
                Application.Run(new Form1());
            }
            catch (Exception exc) 
            {
                // This is the exception handler of last resort.
                // Set flag so that the output file isn't written
                // upon error termination.
                errorFlag = true;
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // This presentation tier maintains phone information in the list box. The ArrayList 
            // is needed temporarily the copy the phones from the business tier.
            //
            ArrayList phones;
            errorFlag = false;
            // A more complete application would have the user specify

            // the filename through a GUI dialog from this layer.
            //

            string filename = "phones.txt";
            app = new PhoneApp();
            phones = app.ReadPhones(filename);

            // Add each phone in the array list to the list box
            //
            foreach (Phone p in phones)
                this.lstBoxPhone.Items.Add(p);

            if (this.lstBoxPhone.Items.Count > 0)
                this.lstBoxPhone.SelectedIndex = 0;

        }

        private void lstNames_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // TODO: Display the phone number for the selected name.
            this.txtBoxPhoneNum.Text = ((Phone)this.lstBoxPhone.SelectedItem).PhoneNumber;
        }


        private void btnNew_Click(object sender, System.EventArgs e)
        {
            // Try to add a new phone number to the list
            try 
            {
                NewPhone frm = new NewPhone();
                if (frm.ShowDialog() == DialogResult.OK) 
                {
                    app.NewPhone(frm.newPhone);
                    this.lstBoxPhone.Items.Add(frm.newPhone);
                    this.lstBoxPhone.SelectedIndex = 0;
                }
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            // Close the form. This will generate the Closing event
            // to write out the data.
            this.Close();
        }


        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // This is called whenever the main form is closed and causes the file to be written.
            //
            if (!errorFlag) 
                app.WritePhones();
        }


    }
}



