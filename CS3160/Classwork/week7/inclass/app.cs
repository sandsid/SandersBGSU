using System;
using System.Windows.Forms;
using System.Drawing;
using UtilityNS


namespace AppNS
{
    public class Greet : Form
    {
        private Button btnSay;
        private TextBox txtName;

        public Greet ()
        {
            this.Text = "Enter your name";
            this.Height = 129;
            this.AcceptButton =  btnSay;
            
            btnSay = new Button();
            btnSay.Text = "How Many Letters?";
            btnSay.Location = new Point(168, 20) ; //x,y
            Controls.Add(btnSay);

            txtName = new TextBox();
            txtName.Location = new Point(35, 8);
            txtName.Size = new Size(208, 20);
            Controls.Add(txtName);

            btnSay.Click += new EventHandler(btnSay_Click);
        }

        void btnSay_Click(Object sender, EventArgs e)
        {
            Utility utl = new Utility();
            string dllversion = "blank";
            int numLetters = 0;
            numLetters = utl.numLetters(txtName.Text, dllversion);


            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Cant count nothing!");
            }
            else
            {
                MessageBox.Show("Hello " + txtName.Text + "!");
            }
            txtName.Clear();
        }
        
        public static void Main()
        {
            Application.Run(new Greet());
        }//main

    }
}