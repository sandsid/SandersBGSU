using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inCLassShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x, y;
            int ranWidth, ranHeight;
            int rangeMinW = 100, rangeMaxW = 150;
            int rangeMinH = 35, rangeMaxH = 50;
            Random rand = new Random();

            ranWidth = rand.Next(rangeMinW, rangeMaxW);
            ranHeight = rand.Next(rangeMinH, rangeMaxH);

            x = MousePosition.X;
            y = MousePosition.Y;

            Rectangle rectangle = new Rectangle(ranWidth, ranHeight);
            //get x and y 
            //pass to method
            //random hight and witdh within range
            //create rec. and draw

        }
    }
}
