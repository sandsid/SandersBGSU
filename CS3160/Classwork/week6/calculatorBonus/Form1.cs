using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorBonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLeft.Focus();


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(txtLeft.Text);
            int num2 = int.Parse(txtRight.Text);

            try
            {
               //move parse
               txtEpression.Text = num1 + " " + " " + num2;
            }
            catch (System.Exception ex)
            {

            }

            
        }
    }
}
