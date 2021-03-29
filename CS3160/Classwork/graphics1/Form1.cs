using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics1
{
    public partial class Form1 : Form
    {
        const int iTimeInterval = 25;     // In milliseconds        
        const int iBallSize = 12;         // As fraction of client area        
        const int iMoveSize = 4;          // As fraction of ball size

        Bitmap bitmap;                    // created on the fly        
        int xCenter, yCenter;        
        int cxRadius, cyRadius, cxMove, cyMove, cxTotal, cyTotal;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            InitializeComponent();

            // Set form's background color to white

            this.BackColor = Color.White;

            // Calculate form's center based on size of the drawing canvas

            xCenter = DisplayRectangle.Width / 2;

            yCenter = DisplayRectangle.Height / 2;

            // Make ball's radius proportional to display area size

            cxRadius = DisplayRectangle.Width / iBallSize;

            cyRadius = DisplayRectangle.Height / iBallSize;

            // Make the amount of movement of the ball proportional to the ball's radius

            cxMove = Math.Max(1, cxRadius / iMoveSize);

            cyMove = Math.Max(1, cyRadius / iMoveSize);

            // Make bitmap size take into account the ball size and extra space around it

            // This is done to avoid erasing previous ball image

            cxTotal = 2 * (cxRadius + cxMove);

            cyTotal = 2 * (cyRadius + cyMove);

            // Create a bitmap

            bitmap = new Bitmap(cxMove, cyMove); // specify the size of the bitmap

            // Create graphics object for alteration from the bitmap

            Graphics grfx = Graphics.FromImage(bitmap);

            // Clear background to whatever color was selected for the form

            grfx.Clear(BackColor);

            // Alter the image by drawing a circle on the bitmap using your choice of brush

            grfx.FillEllipse(___________, new Rectangle(cxMove, cyMove, 2 * cxRadius, 2 * cyRadius));

            // Create a timer, register a timer event handler, and set tick interval

            // Start the timer running...

            Timer timer = new Timer();

            timer.Interval = ____________; // use interval constant defined for the form class

            timer.Tick += new EventHandler(TimerOnTick);

            timer._________; // start the timer
        }

        private void TimerOnTick(object sender, EventArgs e)
        {
            
        }

        public Form1()
        {
            
        }
    }
}
