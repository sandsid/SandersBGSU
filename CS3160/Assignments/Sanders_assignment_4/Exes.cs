using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sanders_assignment_4
{
    public class Exes : Shape
    {
        private int locX, locY;
        private int h, w;
        public Exes(int x1, int y1, int x2, int y2)
        {
            locX = (x1*100) +10;
            locY = (y1*100) + 10;
            w = y2 -20;
            h = x2 -20;
            ItsShape = "X";
        }

        public override void Draw(Graphics g)
        {
            Pen xPen = new Pen(Color.Orange, 3);

            g.DrawLine(xPen, locX, locY, locX + h, locY + w);
            g.DrawLine(xPen, locX + w, locY, locX, locY + h);
        }
        
    }
}
