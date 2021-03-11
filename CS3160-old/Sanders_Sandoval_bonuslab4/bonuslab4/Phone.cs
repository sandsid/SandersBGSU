using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonuslab4
{
    public class Phone
    {
        private string name;
        private string phoneNumber;

        public Phone(string name, string phone)
        {
            name = this.name;
            phoneNumber = phone;
        }
        public string Name
        { 
            get { return this.name; }
            set 
            {
                if (value.IndexOf(",") != -1)
                {
                    this.name = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Name Format");
                }
            } 
        }
        
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set 
            {
                bool allNums = true;
                int i = 0;

                if (value.Length == 10)
                {
                    while (i < value.Length && allNums == true)
                    {
                        if (char.IsDigit(value[i]) == false)
                        {
                            allNums = false;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                if(value.Length == 10 && allNums == true)
                {
                    this.phoneNumber = value;
                }
                else
                {
                    throw new ApplicationException("Invalid Phone Number");
                }
                 
            }
        }

        public override string ToString()
        {
            return name.ToString();
        }

        public override bool Equals(object obj)
        {
            if((obj == null) || (!(obj is Phone)))
            {
                return false;
            }

            Phone other = (Phone)obj;

            if(this.phoneNumber == other.phoneNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return phoneNumber.GetHashCode();
        }

    }
}
