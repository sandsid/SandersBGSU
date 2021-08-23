using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Sanders_assignment_4
{
    class Game
    {
        private int mTurn = 0;
        private Graphics gBoard;

        private void ResetGrid()
        {
            //game is reset
        }

        public int GetTurn()
        {
            return mTurn;
        }
        
        public Game(Graphics g)
        {
            gBoard = g;
            SetGrid();

        }

        public string NewGame()
        {
            ResetGrid();
            return "New Game";
        }

        public void SetGrid()
        {
            Pen lines = new Pen(Color.Black, 3);

            gBoard.DrawLine(lines, new Point(100, 0), new Point(100, 300));
            gBoard.DrawLine(lines, new Point(200, 0), new Point(200, 300));

            gBoard.DrawLine(lines, new Point(0, 100), new Point(300, 100));
            gBoard.DrawLine(lines, new Point(0, 200), new Point(300, 200));


        }

        public string NextMove(Coordinates board, int x, int y)
        {
            while (mTurn >-1 && mTurn < 9)
            {
                if (board.GetCoordinates() == 1 || board.GetCoordinates() == 0)
                {
                    return "Space taken";
                }
                else
                {
                    if (mTurn % 2 == 0)
                    {
                        Ohs move = new Ohs(x, y, 100, 100);
                        move.Draw(gBoard);
                        mTurn++;
                        board.SetCoordinates(x, y, 1);
                        if (IsWin(board) == true)
                        {
                            mTurn = -1;
                            return "O's WIN!";
                        }
                        else
                            return "X's Turn";
                    }
                    else if (mTurn % 2 == 1)
                    {
                        Exes move = new Exes(x, y, x + 100, y + 100);
                        move.Draw(gBoard);
                        mTurn++;
                        board.SetCoordinates(x, y, 0);
                        if (IsWin(board) == true)
                        {
                            mTurn = -1;
                            return "X's WIN!";
                        }
                        else
                            return "O's Turn";
                    }
                    else
                    {
                        return "Error";
                    }
                }
                
            }
            return "Reset to play.";
        }

        public bool IsGameOver(Coordinates board)
        {
            if (mTurn == 9)
                return true;
            else if (IsWin(board) == true)
                return true;
            else
                return false;
        }

        public bool IsWin(Coordinates board)
        {
            Rectangle[,] coords = new Rectangle[3,3];
            coords = board.GetCoords();
            bool isfound = false;
            //MessageBox.Show(coords[0, 0].ToString());
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (board.playerMoves[x, 0].getPlayer() == i &&
                        board.playerMoves[x, 1].getPlayer() == i &&
                        board.playerMoves[x, 2].getPlayer() == i)
                    {
                        isfound = true;
                    }
                    else if (board.playerMoves[0, x].getPlayer() == i &&
                             board.playerMoves[1, x].getPlayer() == i &&
                             board.playerMoves[2, x].getPlayer() == i)
                    {
                        isfound = true;
                    }
                    else if(board.playerMoves[0, 0].getPlayer() == i &&
                            board.playerMoves[1, 1].getPlayer() == i &&
                            board.playerMoves[2, 2].getPlayer() == i)
                    {
                        isfound = true;
                    }
                    else if (board.playerMoves[0, 2].getPlayer() == i &&
                            board.playerMoves[1, 1].getPlayer() == i &&
                            board.playerMoves[2, 0].getPlayer() == i)
                    {
                        isfound = true;
                    }
                }
            }

            return isfound;
        }


    }
}
