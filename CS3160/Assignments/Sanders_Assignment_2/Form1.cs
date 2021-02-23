//*********************************************************************
// Assignment 2 -	 Fast-food restaurant
//			
// Programmer:	Sidney Sanders
// Class:		CS 3160-1001 Spring 2021
//
// File:    Form1.cs
//
//*********************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using purchased;

namespace purchased
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
            gbSize.Enabled = false;
            cbQuantity.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnOrder.Enabled = false;
        }

        private void enableSizes()
        {
            gbSize.Enabled = true;
            
        }

        private void rbtnBurger_CheckedChanged(object sender, EventArgs e)
        {
            enableSizes();
            formItem = 0;
            
        }

        private void rbtnFries_CheckedChanged(object sender, EventArgs e)
        {
            enableSizes();
            formItem = 1;
        }

        private void rbtnSoftDrink_CheckedChanged(object sender, EventArgs e)
        {
            enableSizes();
            formItem = 2;
        }
        
        private void rbtnWater_CheckedChanged(object sender, EventArgs e)
        {
            gbSize.Enabled = false;
            rbtnSmall.Select();
            this.cbQuantity.SelectedIndex = 0;
            formItem = 3;
            formSize = 0;
        }

        private void rbtnSmall_CheckedChanged(object sender, EventArgs e)
        {
            cbQuantity.Enabled = true;
            btnAdd.Enabled = true;
            btnOrder.Enabled = true;
            this.cbQuantity.SelectedIndex = 0;
            formSize = 0;
        }

        private void rbtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            cbQuantity.Enabled = true;
            btnAdd.Enabled = true;
            btnOrder.Enabled = true;
            this.cbQuantity.SelectedIndex = 0;
            formSize = 1;
        }

        private void rbtnLarge_CheckedChanged(object sender, EventArgs e)
        {
            cbQuantity.Enabled = true;
            btnAdd.Enabled = true;
            btnOrder.Enabled = true;
            this.cbQuantity.SelectedIndex = 0;
            formSize = 2;
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PurchasedItem newFood = new PurchasedItem(formItem, formSize, cbQuantity.SelectedIndex + 1);
            lstOrder.Items.Add(newFood.ToString());
            totalCharge = totalCharge + newFood.Cost();
            lblTotal.Text = "$" + totalCharge.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = -1;
            int totalPrice = lstOrder.Items.Count;
            int position = 0;
            char[] price = new char[25];

            if (lstOrder.SelectedIndex != -1)
            {
                index = lstOrder.SelectedIndex;
                string numToRemove = lstOrder.SelectedItem.ToString();
                char[] numArray = numToRemove.ToCharArray();
                for (int i = 0; i < numArray.Length; i++)
                    if (numArray[i].Equals('$'))
                        position = i;


                int a = 0;
                for (int j = position + 1; j < numArray.Length; j++)
                {
                    price[a] = numArray[j];
                    a++;

                }
                char[] p_rice = new char[a];

                for (int q = 0; q < a; q++)
                    p_rice[q] = price[q];

                numToRemove = new string(p_rice);
                decimal toRemove = decimal.Parse(numToRemove);

                //deleting price from total
                totalCharge = totalCharge - toRemove;
                lblTotal.Text = "$" + totalCharge.ToString();

                //removing the item from list
                lstOrder.Items.Remove(lstOrder.SelectedItem);
                totalPrice = lstOrder.Items.Count;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

                dynamic r = MessageBox.Show("Your order is being plced! Do you want to Change your order?",
                    "Five Guys",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (r == DialogResult.No)
                    Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic r = MessageBox.Show("Are you sure you want to exit?",
                    "Five Guys",
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
    }
}
