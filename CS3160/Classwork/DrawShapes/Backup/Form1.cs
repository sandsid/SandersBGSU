using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DrawShapes
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(492, 273);
            this.Name = "Form1";
            this.Text = "Draw Shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.Run(new Form1());
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blue = new Pen(Color.Blue, 3);  
            g.DrawRectangle(blue,10,20,100,50);
            g.FillRectangle(Brushes.Red,150,20,100,50);
            g.DrawLine(blue,10,85,400,85);
            g.DrawEllipse(blue,10,100,100,50);  
            g.FillEllipse(Brushes.Red,150,100,100,50);
            g.DrawArc(blue,270,100,100,50,45,90);
            g.DrawPie(blue,390,100,100,50,45,90);
            Point[] vertices = {new Point(0,246), 
                                   new Point(50,160), new Point(100,246)}; 
            g.DrawPolygon(blue, vertices);                                
            vertices[0].X = 150; 
            vertices[1].X = 200; 
            vertices[2].X = 250;
            g.FillPolygon(Brushes.Red, vertices);
            blue.Dispose();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            MessageBox.Show("Window height is " + 
                this.Size.Height.ToString());
            MessageBox.Show("Display rectangle height is " + 
                this.DisplayRectangle.Height.ToString());
        }
    }
}
