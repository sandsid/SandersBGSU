// Sidney Sanders and Lian Sandoval
// CS 3160 Section 1 Spring 2020
// Lab 3 3/23/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Event
    {

        private DateTime start_date;
        private DateTime end_date;
        private string event_title;

        // overloaded constructor
        public Event(int m, int d, int y, int sh, int sm, int eh, int em, string title)
        {
            start_date = new DateTime(y, m, d, sh, sm, 0);
            end_date = new DateTime(y, m, d, eh, em, 0);
            event_title = title;
        }
        // returns private data members
        public DateTime get_start()
        {
            return start_date;
        }
        public DateTime get_end()
        {
            return end_date;
        }
        public string get_title()
        {
            return event_title;
        }
        // overrides functions 
        public override string ToString()
        {
            return String.Format("{0}-{1}-{2} {3:h}:{4}", start_date.Year, start_date.Month, start_date.Day, start_date.Hour, start_date.Minute);
        }
        public override int GetHashCode()
        {
            return start_date.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Event other;
            if((obj == null) || (!(obj is Event)))
            {
                return false;
            }
            other = (Event)obj;
            return (this.start_date == other.start_date && this.event_title == other.event_title);
        }
    }
}
