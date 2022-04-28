using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w4_inclass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int sum, i, j;

            i = int.Parse(txtNum1.Text);
            j = int.Parse(txtNum2.Text);

            sum = i + j;

            MessageBox.Show("Sum = " + sum);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
