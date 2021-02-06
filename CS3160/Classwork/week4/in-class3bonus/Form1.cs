using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace in_class3bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstAnimals.Items.Add(txtNew.Text);
            txtNew.Clear();
            txtNew.Focus();
            btnAdd.Enabled = false;
            btnClear.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstAnimals.Items.RemoveAt(lstAnimals.SelectedIndex);
            if (lstAnimals.Items.Count < 1)
            {
                btnRemove.Enabled = false;
                btnClear.Enabled = false;
            }
        }

        private void lstAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstAnimals.Items.Clear();
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
            txtNew.Focus();
            txtNew.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Are you sure you want to close?",
                "Exit?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Application.Exit();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Are you sure you want to close?",
                "Exit?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void FillterTextBox(object sender, KeyPressEventArgs e)
        {
            // Let the system handle the key for letters         
            //if (Char.IsLetter(e.KeyChar))
              //  e.Handled = false;
            //else // Ignore: tell the system we handled the character
              //  e.Handled = true;
        }

        private void txtNew_Validated(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            MyErrorProvider.SetError(tb, "");
        }

        private void txtNew_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (String.IsNullOrEmpty(tb.Text))
                tb.Text = "0";
            else if (!Regex.IsMatch(tb.Text, "^[a-zA-Z]+$"))
            {
                e.Cancel = true;
                MyErrorProvider.SetError(tb, "Invalid animal name");
                tb.SelectAll();
            }

        }
    }
}
