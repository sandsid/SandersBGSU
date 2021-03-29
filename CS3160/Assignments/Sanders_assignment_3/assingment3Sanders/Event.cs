// Sidney Sanders 
// CS 3160 Section 1 Spring 2021
// Assignment 3 -- 3/13/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment3Sanders
{
    class Event
    {
        private DateTime startDate;
        private DateTime stopDate;
        private string eventName;


        /// <summary>
        /// creates a new event for the calender creating the start 
        /// and stop times, and adding the tite
        /// </summary>
        public Event (int cMonth, int cDay, int cYear, int startH, int startM,
                      int stopH, int stopM, string title)
        {
            eventName = title;
            startDate = new DateTime(cYear, cMonth, cDay, startH, startM, 0);
            stopDate = new DateTime(cYear, cMonth, cDay, stopH, stopM, 0);
        }


        /// <summary>
        /// Overriden toString to format correctly to the list box.
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0} - {1:00} - {2:00}        {3:00}:{4:00}", startDate.Year, startDate.Month, startDate.Day,startDate.Hour, startDate.Minute);
        }


        /// <summary>
        /// overridden hash code to corrent variable hash.
        /// </summary>
        public override int GetHashCode()
        {
            return startDate.GetHashCode();
        }


        /// <summary>
        /// Overridden equals to see if an event equals an already exsisting event
        /// </summary>
        public override bool Equals(object obj)
        {

            Event otherEvent;
            if ((obj == null) || (!(obj is Event)))
                return false;

            otherEvent = (Event)obj;
            return (this.startDate == otherEvent.startDate && this.eventName == otherEvent.eventName);
        }


        //Calls to return the private members of the class 
        public DateTime getStart()
        {
            return startDate;
        }

        public DateTime getStop()
        {
            return stopDate;
        }

        public string getTitle()
        {
            return eventName;
        }

    }
}
