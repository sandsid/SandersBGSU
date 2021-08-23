using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanders_assignment_4
{
    public partial class Form1 : Form
    {


        private Graphics g;
        private Game tttGame;
        private Coordinates board;

        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void mnuReset_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            lblPlayer.Text = tttGame.NewGame();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = panel1.CreateGraphics();
            tttGame = new Game(g);

            board = new Coordinates();
            board.initializeCoords();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Point click = Cursor.Position;
            click.X = e.X;
            click.Y = e.Y;
            board.SetCord(click);
            
            //lblPlayer.Text = board.GetCoordinates().ToString();

            lblPlayer.Text = tttGame.NextMove(board, board.getXCoord(), board.getYCoord());
            
            
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (tttGame.IsGameOver(board) == true && tttGame.IsWin(board) == false)
            {
                lblPlayer.Text = "Game Tie!";
            }
        }
    }
}
