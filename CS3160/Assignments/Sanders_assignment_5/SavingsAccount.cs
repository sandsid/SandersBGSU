using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanders_assignment_5
{
    class SavingsAccount : Account, IAccount
    {
        public bool credit;
        public bool debit;
        public decimal interest;

        public bool IsCredit 
        {
            get { return credit; }
            set { credit = value; } 
        }
        public bool IsDebit 
        {
            get { return debit; }
            set { debit = value; } 
        }
        public decimal IsBalance 
        { 
            get { return this.Balance; } 
        }

        /// <summary>
        /// Creates the Savings account 
        /// assigns variables for account
        /// </summary>
        public SavingsAccount(string name, int id, decimal bal, decimal intAmount)
        {
            this.Balance = bal;
            this.Interest = intAmount;
            AddAccount(name, id);
        }

        /// <summary>
        /// Add more account information
        /// </summary>
        void AddAccount(string name, int id)
        {
            this.Owner = name;
            this.ID = id;
        }

        /// <summary>
        /// Calculate and return the interest amount 
        /// (365 not 360)
        /// </summary>
        decimal CalculateInterest ()
        {
            decimal result = 0;
            result = (this.interest * this.Balance)/365;
            return result;
        }

        /// <summary>
        /// overridden tostring 
        /// </summary>
        public override string ToString()
        {
            return ($"Savings:\t\t{accOwner}\t\t{accBalance:C}");
        }
        
        void IAccount.AddCredit(decimal amount)
        {
            throw new NotImplementedException();
        }

        void IAccount.DebitWithdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
