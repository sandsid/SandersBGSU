using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5_inclass3_errorHandling
{
    public partial class Form1 : Form
    {
        public string V { get; }

        public Form1(string[] args)
        {
            InitializeComponent();
        }

        public Form1(string v)
        {
            V = v;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {

        }
    }
}
