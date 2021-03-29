using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sanders_assignment_4
{
    public abstract class Shape
    {
        public string ItsShape { get; set;  }
        public static Graphics g;

        public Shape()
        {

            ItsShape = "";
        }

        public abstract void Draw(Graphics g);



    }
}
