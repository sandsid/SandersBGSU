using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sanders_assignment_5
{
    class InterstellarBank 
    {
        private ArrayList mAccounts = new ArrayList(15);
        private int amount;

        public InterstellarBank()
        {
            amount = -1;
            mAccounts = new ArrayList();
        }

        /// <summary>
        /// creates a new checing account, fills in account information
        /// Adds account to array list
        /// </summary>
        public void AddChecking(string name, decimal bal, decimal fee)
        {
            if (bal >= 0)
            {
                CheckingAccount newAccount;
                amount++;
                newAccount = new CheckingAccount(name, amount, bal, fee);
                newAccount.IsDebit = true;
                newAccount.IsCredit = false;

                mAccounts.Add(newAccount);
            }
            else
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// creates a new savings account,
        /// fills in account information
        /// Adds account to the arraylist
        /// </summary>
        public void AddSaving(string name, decimal bal, decimal interest)
        {
           if (bal >= 0)
           {
                SavingsAccount newAccount;
                amount++;
                newAccount = new SavingsAccount(name, amount, bal, interest);
                newAccount.IsCredit = true;
                newAccount.IsDebit = false;
            
                mAccounts.Add(newAccount);
           }
           else
           {
                throw new Exception("Balance can't be negative");
           }
        }

        /// <summary>
        /// Returns the calculated interest of the account
        /// </summary>
        public decimal GetInterest(int id)
        {
            Account findingInt = (Account)mAccounts[id];
            decimal result = (findingInt.Interest * findingInt.Balance) / 365;
            return result;
        }

        /// <summary>
        /// Indexer for arraylist
        /// </summary>
        public Account this[int i]
        {
            get 
            { 
                return (Account)this.mAccounts[i]; 
            }
            set
            {
                this.mAccounts[i] = value;
            }
        }

        /// <summary>
        /// Adds interest to the balance
        /// updates account balance
        /// </summary>
        public void Credit(decimal interest, int id)
        {
            Account balanceChange = (Account)mAccounts[id];
            balanceChange.Balance += interest;
            mAccounts[id] = balanceChange;
        }

        /// <summary>
        /// Subtracts the withdraw amount
        /// updates the account balance
        /// </summary>
        public void Debit(decimal withdraw, int id)
        {
            Account balanceWithdraw = (Account)mAccounts[id];
            balanceWithdraw.Balance -= withdraw;
            mAccounts[id] = balanceWithdraw;

        }

        public int Accounts
        {
            get { return amount; }
        }
    }
}
