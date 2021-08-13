using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using StdDialogs;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        private Image mAppLogo;

        /// <summary>
        /// Grab image from references
        /// Show the splash screen for passed amount of time.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream myStream = myAssembly.GetManifestResourceStream("TextEditor.logo.jpg");
            mAppLogo = Image.FromStream(myStream);


            SplashAbout splash = new SplashAbout(5000, mAppLogo, "Simple Text Editor", "Copyright (c) 2021", "Sidney Sanders");
            splash.Show();
        }

        private void clearMenuItem_Click(object sender, EventArgs e)
        {
            txtRichEditor.Clear();
        }

        private void fontMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult font = fontDialog.ShowDialog();
            if (font == DialogResult.OK)
            {
                txtRichEditor.Font = fontDialog.Font;
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// call the aboutbox from the dll
        /// </summary>
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox frm = new AboutBox(mAppLogo, "Simple Text Editor", "Copyright (c) 2021", "Sidney Sanders");
            frm.Show();

        }
    }
}
