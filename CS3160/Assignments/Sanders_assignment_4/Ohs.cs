using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Sanders_assignment_4
{
    class Ohs : Shape
    {
        private int locX, locY;
        private int h, w;
        public Ohs(int x1, int y1, int x2, int y2)
        {
            locX = (x1 * 100) + 10;
            locY = (y1 * 100) + 10;
            w = y2 - 20;
            h = x2 - 20;
            ItsShape = "O";
        }

        public override void Draw(Graphics g)
        {
            Pen oPen = new Pen(Color.Brown, 3);

            g.DrawEllipse(oPen, locX, locY, h, w);
        }

    }
}
