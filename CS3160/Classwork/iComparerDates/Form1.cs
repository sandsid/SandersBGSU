using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iComparerDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime[] dates = new DateTime[8];

            dates[0] = new DateTime(1987, 12, 13); 
            dates[1] = new DateTime(1992, 3, 14); 
            dates[2] = new DateTime(1995, 4, 1); 
            dates[3] = new DateTime(1985, 12, 4); 
            dates[4] = new DateTime(1997, 1, 9); 
            dates[5] = new DateTime(1973, 3, 14); 
            dates[6] = new DateTime(1987, 11, 30); 
            dates[7] = new DateTime(1987, 12, 1);

            Array.Sort(dates, new MonthlyDateComparer());

            //format tostring?
            foreach (DateTime d in dates)
                lstDates.Items.Add(d);
        }
    }
}
