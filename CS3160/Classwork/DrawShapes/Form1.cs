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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuClear;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuShape;
        private ToolStripMenuItem mnuLine;
        private ToolStripMenuItem mnuEllipse;
        private ToolStripMenuItem mnuRectangle;
        private ToolStripMenuItem mnuColor;
        private ToolStripMenuItem mnuBlack;
        private ToolStripMenuItem mnuBlue;
        private ToolStripMenuItem mnuGreen;
        private ToolStripMenuItem mnuRed;

        private enum ShapeType { Line, Ellipse, Rectangle };
        private enum LineThickness { Thin=1, Average=2, Thick=4 };

        // Keep track of menu selections
        //
        private Color           selectedColor;
        private ShapeType       selectedShape;
        private LineThickness   selectedThickness;
      
        private int x0, y0;
        private Graphics g;

        private ToolStripMenuItem mnuThickness;
        private ToolStripMenuItem mnuThin;
        private ToolStripMenuItem mnuAverage;
        private ToolStripMenuItem mnuThick;
        private ToolStripSeparator toolStripSeparator1;

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

            selectedColor = Color.Black;
            selectedShape = ShapeType.Line;
            selectedThickness = LineThickness.Thin;
            g = this.CreateGraphics();
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
            g.Dispose();
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShape = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRed = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThickness = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAverage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThick = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuShape,
            this.mnuColor,
            this.mnuThickness});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClear,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuClear
            // 
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.Size = new System.Drawing.Size(180, 22);
            this.mnuClear.Text = "Clear";
            this.mnuClear.Click += new System.EventHandler(this.mnuClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuShape
            // 
            this.mnuShape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLine,
            this.mnuEllipse,
            this.mnuRectangle});
            this.mnuShape.Name = "mnuShape";
            this.mnuShape.Size = new System.Drawing.Size(51, 20);
            this.mnuShape.Text = "Shape";
            // 
            // mnuLine
            // 
            this.mnuLine.Name = "mnuLine";
            this.mnuLine.Size = new System.Drawing.Size(126, 22);
            this.mnuLine.Text = "Line";
            this.mnuLine.Click += new System.EventHandler(this.mnuLine_Click);
            // 
            // mnuEllipse
            // 
            this.mnuEllipse.Name = "mnuEllipse";
            this.mnuEllipse.Size = new System.Drawing.Size(126, 22);
            this.mnuEllipse.Text = "Ellipse";
            this.mnuEllipse.Click += new System.EventHandler(this.mnuEllipse_Click);
            // 
            // mnuRectangle
            // 
            this.mnuRectangle.Name = "mnuRectangle";
            this.mnuRectangle.Size = new System.Drawing.Size(126, 22);
            this.mnuRectangle.Text = "Rectangle";
            this.mnuRectangle.Click += new System.EventHandler(this.mnuRectangle_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBlack,
            this.mnuBlue,
            this.mnuGreen,
            this.mnuRed});
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(48, 20);
            this.mnuColor.Text = "Color";
            // 
            // mnuBlack
            // 
            this.mnuBlack.Name = "mnuBlack";
            this.mnuBlack.Size = new System.Drawing.Size(105, 22);
            this.mnuBlack.Text = "Black";
            this.mnuBlack.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // mnuBlue
            // 
            this.mnuBlue.Name = "mnuBlue";
            this.mnuBlue.Size = new System.Drawing.Size(105, 22);
            this.mnuBlue.Text = "Blue";
            this.mnuBlue.Click += new System.EventHandler(this.mnuBlue_Click);
            // 
            // mnuGreen
            // 
            this.mnuGreen.Name = "mnuGreen";
            this.mnuGreen.Size = new System.Drawing.Size(105, 22);
            this.mnuGreen.Text = "Green";
            this.mnuGreen.Click += new System.EventHandler(this.mnuGreen_Click);
            // 
            // mnuRed
            // 
            this.mnuRed.Name = "mnuRed";
            this.mnuRed.Size = new System.Drawing.Size(105, 22);
            this.mnuRed.Text = "Red";
            this.mnuRed.Click += new System.EventHandler(this.mnuRed_Click);
            // 
            // mnuThickness
            // 
            this.mnuThickness.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThin,
            this.mnuAverage,
            this.mnuThick});
            this.mnuThickness.Name = "mnuThickness";
            this.mnuThickness.Size = new System.Drawing.Size(70, 20);
            this.mnuThickness.Text = "Thickness";
            // 
            // mnuThin
            // 
            this.mnuThin.Checked = true;
            this.mnuThin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuThin.Name = "mnuThin";
            this.mnuThin.Size = new System.Drawing.Size(180, 22);
            this.mnuThin.Text = "Thin";
            this.mnuThin.Click += new System.EventHandler(this.mnuThin_Click);
            // 
            // mnuAverage
            // 
            this.mnuAverage.Name = "mnuAverage";
            this.mnuAverage.Size = new System.Drawing.Size(180, 22);
            this.mnuAverage.Text = "Average";
            this.mnuAverage.Click += new System.EventHandler(this.mnuAverage_Click);
            // 
            // mnuThick
            // 
            this.mnuThick.Name = "mnuThick";
            this.mnuThick.Size = new System.Drawing.Size(180, 22);
            this.mnuThick.Text = "Thick";
            this.mnuThick.Click += new System.EventHandler(this.mnuThick_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(492, 273);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Draw Shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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


        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Black;
            mnuBlack.Checked = true;
            mnuBlue.Checked = false;
            mnuGreen.Checked = false;
            mnuRed.Checked = false;
        }

        private void mnuBlue_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Blue;
            mnuBlack.Checked = false;
            mnuBlue.Checked = true;
            mnuGreen.Checked = false;
            mnuRed.Checked = false;
        }

        private void mnuLine_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeType.Line;
            mnuLine.Checked = true;
            mnuEllipse.Checked = false;
            mnuRectangle.Checked = false;
        }

        private void mnuGreen_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Green;
            mnuBlack.Checked = false;
            mnuBlue.Checked = false;
            mnuGreen.Checked = true;
            mnuRed.Checked = false;
        }

        private void mnuRed_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Red;
            mnuBlack.Checked = false;
            mnuBlue.Checked = false;
            mnuGreen.Checked = false;
            mnuRed.Checked = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuClear_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.x0 = e.X;
            this.y0 = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen myPen = new Pen(selectedColor, (int)selectedThickness);    

            // how would we select the correct shape type
            // based on user's menu selection?
            if (selectedShape == ShapeType.Line)
                g.DrawLine(myPen, this.x0, this.y0, e.X, e.Y);
            else if (selectedShape == ShapeType.Ellipse)
                g.DrawEllipse(myPen, new Rectangle(this.x0, this.y0, e.X-this.x0, e.Y-this.y0));
            else if (selectedShape == ShapeType.Rectangle)
                g.DrawRectangle(myPen, this.x0, this.y0, e.X - this.x0, e.Y - this.y0);

            myPen.Dispose();
        }

        private void mnuEllipse_Click(object sender, EventArgs e)
        {
            mnuEllipse.Checked = true;
            mnuLine.Checked = false;
            mnuRectangle.Checked = false;
            selectedShape = ShapeType.Ellipse;
        }

        private void mnuRectangle_Click(object sender, EventArgs e)
        {
            mnuEllipse.Checked = false;
            mnuLine.Checked = false;
            mnuRectangle.Checked = true;
            selectedShape = ShapeType.Rectangle;
        }

        private void mnuThin_Click(object sender, EventArgs e)
        {
            mnuThin.Checked = true;
            mnuAverage.Checked = false;
            mnuThick.Checked = false;
            selectedThickness = LineThickness.Thin;
        }

        private void mnuAverage_Click(object sender, EventArgs e)
        {
            mnuThin.Checked = false;
            mnuAverage.Checked = true;
            mnuThick.Checked = false;
            selectedThickness = LineThickness.Average;
        }

        private void mnuThick_Click(object sender, EventArgs e)
        {
            mnuThin.Checked = false;
            mnuAverage.Checked = false;
            mnuThick.Checked = true;
            selectedThickness = LineThickness.Thick;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            mnuBlack.Checked = true;
            mnuLine.Checked = true;
        }
    }
}
