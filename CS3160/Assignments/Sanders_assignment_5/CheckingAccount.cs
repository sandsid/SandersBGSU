using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanders_assignment_5
{
    class CheckingAccount : Account, IAccount
    {
        private bool credit;
        private bool debit;

        
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
            get { return this.accBalance; }
        }

        /// <summary>
        /// Adds information to the account variables
        /// </summary>
        public CheckingAccount(string name, int id, decimal bal, decimal feeAmount)
        {
            this.Balance = bal;
            this.Fee = feeAmount;
            AddAccount(name, id);
        }

        /// <summary>
        /// add account information to the variables
        /// </summary>
        void AddAccount(string name, int id)
        {
            this.Owner = name;
            this.ID = id;
        }

        /// <summary>
        /// Ovveridden tostring
        /// </summary>
        public override string ToString()
        {
            string output = string.Format($"Checking: {accOwner,20}  {accBalance,15:C}");
            string test = $"Checking:\t\t{accOwner}\t\t{accBalance:C}";
            return test;
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
