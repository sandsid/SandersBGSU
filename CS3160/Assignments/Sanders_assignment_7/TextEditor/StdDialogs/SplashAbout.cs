using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdDialogs
{
    public partial class SplashAbout : Form
    {

        /// <summary>
        /// SPLASH screen that will show for the passed in time amount when called
        /// and close once the time runs out
        /// </summary>
        public SplashAbout(int time, Image im, string title, string cpyright, string author)
        {
            InitializeComponent();

            this.pictureBox1.Image = im;
            this.lblTitle.Text = title;
            this.lblCopyRight.Text = cpyright;
            this.lblAuthor.Text = author;

            timer1.Interval = time;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
