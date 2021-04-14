using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanders_assignment_5
{
    interface IAccount
    {
        bool IsCredit { get;  } 
        bool IsDebit { get;  }
        decimal IsBalance { get; }

        void AddCredit(decimal amount);
        void DebitWithdraw(decimal amount);

    }
}
