using C = System.Console;

namespace MyDate
{
    public class Date
    {
        private int month;
        private int day;


        public int getMonth()
        {
            return month;
        }
        public int setMonth(int m)
        {
            month = m;
        }
        public int Day
        {
            get {return day;}
            set { Day = value;}
        }

        public int year { get; set; }


        public Date(int m, int d)
        {
            month = m;
            day = d;
            Year = this.get;

        }

        public string DisplayDate()
        {
            C.WriteLine(this);
        }

        public override string ToString()
        {
            string line = "";
            string dateZero = value.toString("D").length+1;
            

            line = $"{this.getMonth}/{this.Day}/{this.year}";
            return line;
        }
        public override int GetHashCode()
        {   
            // delegate hash code computation to underlying integer class...  
            return this.ID.GetHashCode();
        }
    }

}//namespace