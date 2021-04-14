using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanders_assignment_5
{
    class Account
    {
        protected string accOwner;
        protected int accID;
        protected decimal accBalance;
        protected decimal accInterest;
        protected decimal accFee;

        public decimal Balance
        {
            get { return accBalance; }
            set
            {
                if (value >= 0)
                    accBalance = value;
                else
                    throw new Exception("Balance can't be negative");
            }
        }

        public int ID
        {
            get { return accID; }
            set
            {
                accID = value;
            }
        }

        public string Owner
        {
            get { return accOwner; }
            set { accOwner = value; }
        }

        public decimal Interest
        {
            get { return accInterest; }
            set { accInterest = value; }
        }

        public decimal Fee
        {
            get { return accFee; }
            set { accFee = value; }
        }
    }
}
