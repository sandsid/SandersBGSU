using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w5_inclass1
{
    public partial class Form1 : Form
    {
        private int ImageNumber { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.ImageNumber = this.ImageNumber + 1;
            int next = this.ImageNumber % 3;
            picCats.Image = (Image)Properties.Resources.ResourceManager.GetObject($"kitty{next}");
        }
    }
}
