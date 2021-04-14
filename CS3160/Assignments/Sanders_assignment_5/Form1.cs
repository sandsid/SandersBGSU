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

namespace Sanders_assignment_5
{
    public partial class Form1 : Form
    {
        private InterstellarBank m_bank;
        private int index;

        /// <summary>
        /// initializing the account array, 
        /// filling it with pre-determind account information
        /// Printing all account sto the List box
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            int i = 0;
            m_bank = new InterstellarBank();
            try
            {
                m_bank.AddChecking("Smith", 1000, 1.0M);
                m_bank.AddSaving("Smith", 23456, 0.03M);
                m_bank.AddChecking("Jones", 234, 1.0M);
                m_bank.AddSaving("Jones", 10000, 0.02M);
                m_bank.AddChecking("Doe", 124, 1.0M);
                m_bank.AddSaving("Sanders", 2000, 0.02M);
                m_bank.AddChecking("Sanders", 200, 1.0M);
                m_bank.AddSaving("Rafeld", 1850, 0.02M);
                m_bank.AddChecking("Rafeld", 175, 1.0M);
            }
            catch (Exception e)
            {
                txtMessage.Text = e.ToString();
            }

            for (i = 0; i <= m_bank.Accounts; i++)
            {
                lstAccounts.Items.Add(m_bank[i]);
            }

        }


        /// <summary>
        /// Button to add interest to the savings account
        /// Checks if credit is selected,
        /// changes balance
        /// This will return nothing 
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e) //add interest
        {
            txtMessage.Text = "";
            if (cboCardType.Text == "Credit")
            {
                decimal interest = m_bank.GetInterest(index);

                m_bank.Credit(interest, index);
            }
            else
            {
                txtMessage.Text = "Must have Credit Selected";
            }

        }

        /// <summary>
        /// Button to update the Checking account with the withdraw amount
        /// Checks if debit is selected, 
        /// Checks if the account has enogu hmoney
        /// changes balance
        /// returns nothing
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e) //update account
        {
            txtMessage.Text = "";
            decimal withdraw = int.Parse(txtAmount.Text) + m_bank[index].Fee;
            if (cboCardType.Text == "Debit")
            {
                if (m_bank[index].Balance >= withdraw)
                {
                    m_bank.Debit(withdraw, index);
                }
                else
                {
                    txtMessage.Text = "Insufficient Funds";
                }
            }
            else
            {
                txtMessage.Text = "Must have Debit Selected";
            }
        }

        /// <summary>
        /// Exits application
        /// returns nothing
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Will update the global index,
        /// reset the message box 
        /// </summary>
        private void lstAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lstAccounts.SelectedIndex;
            txtMessage.Text = "";
        }

        /// <summary>
        /// Resets the Listbox to show update account information
        /// </summary>
        private void btnAdd_MouseUp(object sender, MouseEventArgs e)
        {

            int i = 0;
            lstAccounts.Items.Clear();
            for (i = 0; i <= m_bank.Accounts; i++)
            {
                lstAccounts.Items.Add(m_bank[i]);
            }

        }

        /// <summary>
        /// Resets the Listbox to show updated account information
        /// </summary>
        private void btnUpdate_MouseUp(object sender, MouseEventArgs e)
        {

            int i = 0;
            lstAccounts.Items.Clear();
            for (i = 0; i <= m_bank.Accounts; i++)
            {
                lstAccounts.Items.Add(m_bank[i]);
            }

        }
    }
}
