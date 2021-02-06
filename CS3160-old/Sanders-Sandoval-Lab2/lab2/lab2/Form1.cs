using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab2_1;

namespace lab2
{
    public partial class Form1 : Form
    {
        private int formItem;
        private int formSize;
        private decimal totalCharge;
        
        
        public Form1()
        {
            InitializeComponent();     
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            grpSize.Enabled = false;
            cboQuantity.Enabled = false;
            btnDelete.Enabled = false;
            btnOrder.Enabled = false;
            lblTotal.Text = "$0.00";
            
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //asks if user is sure about closing application
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic r = MessageBox.Show("Are you sure you want to exit?",
                    "Rick's Sandwich Shop",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (r == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (r == DialogResult.Yes)
                {
                    e.Cancel = false;
                    Application.Exit();
                }
            }
        }

        private void radWater_CheckedChanged(object sender, EventArgs e)
        {
            //preselects the size to small and enables the quantity to be changed
            grpSize.Enabled = false;
            radSmall.Select();
            this.cboQuantity.SelectedIndex = 0;
            formItem = 3;
            formSize = 0;
        }
        private void enableSizes()
        {
            grpSize.Enabled = true;
        }

        private void radSandwich_CheckedChanged(object sender, EventArgs e)
        {
            radSmall.Checked = false;
            enableSizes();
            formItem = 0;
            cboQuantity.Enabled = false;
        }

        private void radFries_CheckedChanged(object sender, EventArgs e)
        {
            radSmall.Checked = false;
            enableSizes();
            formItem = 1;
            cboQuantity.Enabled = false;
        }

        private void radSoftDrink_CheckedChanged(object sender, EventArgs e)
        {
            radSmall.Checked = false;
            enableSizes();
            formItem = 2;
            cboQuantity.Enabled = false;
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            cboQuantity.Enabled = true;
            cboQuantity.SelectedIndex = 0;
            btnOrder.Enabled = true;
            formSize = 0;
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            cboQuantity.Enabled = true;
            cboQuantity.SelectedIndex = 0;
            btnOrder.Enabled = true;
            formSize = 1;
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            cboQuantity.Enabled = true;
            cboQuantity.SelectedIndex = 0;
            btnOrder.Enabled = true;
            formSize = 2;
        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //adds order to the list box
            PurchasedItem food_item = new PurchasedItem(formItem, formSize, cboQuantity.SelectedIndex + 1);
            lstOrder.Items.Add(food_item.ToString());
            totalCharge += food_item.Cost();
            lblTotal.Text = "$" + totalCharge.ToString();

            //clears all radio buttons and disables size and quantity 
            radFries.Checked = false;
            radSandwich.Checked = false;
            radSoftDrink.Checked = false;
            radWater.Checked = false;
            radSmall.Checked = false;
            radMedium.Checked = false;
            radLarge.Checked = false;
            cboQuantity.SelectedIndex = 0;
            grpSize.Enabled = false;
            cboQuantity.Enabled = false;


        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstOrder.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = -1;
            int total = lstOrder.Items.Count;
            int position = 0;
            char[] price = new char[10];

            if(lstOrder.SelectedIndex != -1)
            {
                index = lstOrder.SelectedIndex;
                //getting a string to find the price to remove
                string costToRemve = lstOrder.SelectedItem.ToString();
                char[] numArray = costToRemve.ToCharArray();
                for (int i = 0; i < numArray.Length; i++)
                {
                    if (numArray[i].Equals('$'))
                    {
                        position = i;

                    }

                }
                int k = 0;
                //finding price location in the string
                for (int j = position + 1; j<numArray.Length; j++)
                {
                    price[k] = numArray[j];
                    k++;

                }
                char[] p_rice = new char[k];
                //creating a char array with only the price in it
                for(int q = 0; q < k; q++)
                {
                    p_rice[q] = price[q];
                }
                //converting from char arry into a decimal
                costToRemve =  new string(p_rice);
                decimal toRemove = decimal.Parse(costToRemve);
                
                //deleting price from total
                totalCharge = totalCharge - toRemove;
                lblTotal.Text = "$" + totalCharge.ToString();

                //removing the item from list
                lstOrder.Items.Remove(lstOrder.SelectedItem);
                total = lstOrder.Items.Count;
            }
            //keep an item selected in the box
            if(index > -1)
            {
                if(index >=total)
                {
                    lstOrder.SelectedIndex = index - 1;
                }
                else
                {
                    lstOrder.SelectedIndex = index;
                }
                if(total == 0)
                {
                    btnDelete.Enabled = false;
                }
            }
        }
    }
}
