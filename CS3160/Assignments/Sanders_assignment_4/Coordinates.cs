using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Sanders_assignment_4
{
    class Coordinates
    {
        
        private Rectangle[,] coords = new Rectangle[3, 3];
        public Moves[,] playerMoves = new Moves[3, 3];
        private int xCoord = 0;
        private int yCoord = 0;
        public const int X = 0;
        public const int O = 1;
        public const int C = 2;
        


        public void initializeCoords()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    coords[i, j] = new Rectangle(i*100, j*100, 100, 100);
                    playerMoves[i, j] = new Moves();
                    playerMoves[i, j].setPlayer(C);
                    playerMoves[i, j].setMoveCoord(new Point(i, j));
                }
            }
        }
        public Rectangle[,] GetCoords()
        {
            return coords;
        }
        public int GetCoordinates()
        {
            return playerMoves[xCoord, yCoord].getPlayer();
        }

        public void SetCoordinates(int x, int y, int turn)
        {
            playerMoves[x, y].setPlayer(turn);
        }
        public void SetCord(Point p)
        {

            if (p.X < 100)
                xCoord = 0;
            else if (p.X > 100 && p.X < 200)
                xCoord = 1;
            else if (p.X > 200)
                xCoord = 2;

            if (p.Y < 100)
                yCoord = 0;
            else if (p.Y > 100 && p.Y < 200)
                yCoord = 1;
            else if (p.Y > 200)
                yCoord = 2;

            //MessageBox.Show(xCoord.ToString() + ", " + yCoord.ToString() + "\n\n" + p);
        }

        public int getXCoord ()
        {
            return xCoord;
        }

        public int getYCoord ()
        {
            return yCoord;
        }
    }

    class Moves
    {
        private Point moveCoord;
        private int player = Coordinates.C;

        public void setMoveCoord(Point p)
        {
            moveCoord = p;
        }
        public Point getMoveCoord()
        {
            return moveCoord;
        }

        public void setPlayer(int i)
        {
            player = i;
        }
        public int getPlayer()
        {
            return player;
        }
    }
}
