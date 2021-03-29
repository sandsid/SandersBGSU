using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            Person [] people = new Person[2];
            people[0] = new Person("Donald Duck", 83);
            people[1] = new Person("Donald Trump", 70);

            int ret = people[0].CompareTo(people[1]);
            if (ret > 1)
                MessageBox.Show("I'm Older");

            Array.Sort(people);

            foreach (Person p in people)
                lstPeople.Items.Add(p);
        }
    }
}
