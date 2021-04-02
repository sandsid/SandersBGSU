using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iComparerDates
{
    public class MonthlyDateComparer : IComparer<DateTime>
    {
        public int Compare(DateTime a, DateTime b)
        {
            if (a.Month.CompareTo(b.Month) != 0)
                return a.Month.CompareTo(b.Month);
            else if (a.Day.CompareTo(b.Day) != 0)
                return a.Day.CompareTo(b.Day);
            else
                return 0;

        }


}
}
