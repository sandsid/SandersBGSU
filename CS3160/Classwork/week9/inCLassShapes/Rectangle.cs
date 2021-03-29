using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inCLassShapes
{
    class Rectangle
    {
        private int mWidth, mHeight;
        private Random random;

        public Rectangle(int w, int h)
        {
            mWidth = w;
            mHeight = h;
        }
        public int Area
        {
            get { return mWidth * mHeight; }
        }

        public void Draw(Graphics g, int x, int y) 
        {
            Color ranColor = GetRandomColor();
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(ranColor, 2);
            g.DrawRectangle(myPen, x, y, mWidth, mHeight);

        }

        private Color GetRandomColor()
        {
            random = new Random();
            return Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }

    }
}
