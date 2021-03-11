using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace midtermSupplement
{
    public class Employee
    {
        private string fName;
        private string lName;
        private string email;
        private decimal salary;


        public Employee()
        {
            this.fName = "";
            this.lName = "";
            this.email = "";
            this.salary = 0;
        }
        public Employee(string fName, string lName, string email, decimal salary)
        {
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.salary = salary;
        }

        public string Salary
        {
            get 
            {
                return this.salary.ToString("C", CultureInfo.CurrentCulture); 
            }

            set 
            {
                this.salary = decimal.Parse(value);
            }
        }
        public string Email
        {
            get { return this.email; }
            set { }
        }

        public override string ToString()
        {
            return this.lName + ", " + this.fName;
        }
    }
}
