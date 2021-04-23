using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Lab6;

namespace PhoneApp
{
    public class Phone
    {
        /// <summary>
        /// There is one Phone object per phone number in the
        /// database.
        /// </summary>
        private string mFullName;
        private string mPhoneNumber;
        Regex validNumformat = new Regex(@"^(419)?\d{10}$");
        Regex validNum = new Regex(@"^((419)?(\s*|-)\d{3}(\s|-)\d{4}|419\d{7}|\d{3}(\s|-)\d{4}|\d{7})$");
        Regex validName = new Regex(@"^[^-\s]('|)[a-zA-z]{1,}('|)[a-zA-Z]{1,}('|)(,)(\s|,|'|-){1,}[a-zA-Z]{1,}$");
        private bool isvalidname;
        private bool isvalidphoneNum;
        MyFieldException ex;



        public Phone(string name, string phone)
        {
            // Use the properties so that data validation is done.
            Name = name;
            PhoneNumber = phone;
        }

        public Phone()
        {
            //Name = null;
            //PhoneNumber = null;
        }

        public string Name
        {
            get { return mFullName; }
            set
            {
                string result = ValidateName(value);
                if (result != "")
                {
                    mFullName = result;
                    ValidName = true;
                }
                else
                {
                    ValidName = false;
                }
            }
        }

        public string PhoneNumber
        {
            get { return mPhoneNumber; }
            set
            {
                string result = ValidatePhoneNumber(value);

                if (validNumformat.IsMatch(result))
                {
                    mPhoneNumber = result;
                    ValidPhoneNumber = true;
                }
                else if (result == "")
                {
                    ValidPhoneNumber = false;
                }
                
            }
        }

        public string PhoneNumberDisplay
        {
            get
            {
                string result = PhoneNumber;
                result = Regex.Replace(result, "(.{3})(.{3})(.{4})", "$1-$2-$3"); 
                return result;
            }
        }
        public bool ValidName
        {
            get { return isvalidname; }
            set { isvalidname = value; }
        }
        public bool ValidPhoneNumber
        {
            get { return isvalidphoneNum; }
            set { isvalidphoneNum = value; }
        }

        public static string ValidateName (string n)
        {

            string name = n; 
            Regex check = new Regex(@"^[^-\s]('|)[a-zA-z]{1,}('|)[a-zA-Z]{1,}('|)(\,)(\s|,|'|-){1,}[a-zA-Z]");
            Regex checkComma = new Regex(@"(\,)");

            if (name == "" || name == null)
            {
                
                FieldExceptionForm frm = new FieldExceptionForm("Empty Field", "Name", n);
               
            }
            else if(check.IsMatch(name))
            {
                return name;
            }
            else if (!checkComma.IsMatch(name))
            {
                throw new MyFieldException("Must have Comma", "Name", n);
            }

            return "";
        }

        public static string ValidatePhoneNumber (string pn)
        {
            Regex check = new Regex(@"^((419)?(\s*|-)\d{3}(\s|-)\d{4}|419\d{7}|\d{3}(\s|-)\d{4}|\d{7})$");
            Regex checkLength = new Regex(@"^(\d{3}(\s|-)\d{4}|\d{7})$");
            Regex check419 = new Regex(@"^((?=419)\d{10}$)");
            string phoneNum = pn;
            if (pn == "")
            {
                throw new MyFieldException("Empty Field", "Phone Number", pn);
            }
            else if (check.IsMatch(pn))
            {
                if (checkLength.IsMatch(pn))
                {
                    pn = "419" + pn;
                    Regex.Replace(pn, @"[^0-9]", "");
                    return pn;
                }
                else
                {
                    Regex.Replace(pn, @"[^0-9]", "");
                    return pn;
                }
            }
            else
            {
                Regex.Replace(phoneNum, @"[^0-9]", "");
                if (pn.Length == 10)
                {
                    if (!check419.IsMatch(phoneNum))
                    {
                        throw new MyFieldException("Invalid area code", "Phone Number", pn);
                    }
                }
                else
                {
                    throw new MyFieldException("Must input 7 or 10 digit", "Phone Number", pn);
                }
                
                if (check419.IsMatch(phoneNum))
                {
                    throw new MyFieldException("Check Dashes/Parentheses", "Phone Number", pn);
                }
            }

            return "";
        }

        public override string ToString()
        {
            return mFullName;
        }

        public override bool Equals(object obj)
        {
            Phone other;
            // Make sure we're comparing two Phone objects.
            if (obj == null || !(obj is Phone))
                return false;
            // Two Phone objects are equal if the phone numbers are
            // the same.
            other = (Phone)obj;
            return mPhoneNumber == other.PhoneNumber;
        }

        public override int GetHashCode()
        {
            // Just hash the phone number.
            return mPhoneNumber.GetHashCode();
        }
    }
}
