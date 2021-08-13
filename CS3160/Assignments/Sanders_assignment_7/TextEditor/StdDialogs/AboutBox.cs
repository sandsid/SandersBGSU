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
    public partial class AboutBox : Form
    {

        /// <summary>
        /// create the infrmation page with the passes information
        /// close when ok button is clicked
        /// </summary>
        public AboutBox(Image im, string title, string cpyright, string author)
        {
            InitializeComponent();

            this.pictureBox1.Image = im;
            this.lblTitle.Text = title;
            this.lblCopyRight.Text = cpyright;
            this.lblAuthor.Text = author;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
