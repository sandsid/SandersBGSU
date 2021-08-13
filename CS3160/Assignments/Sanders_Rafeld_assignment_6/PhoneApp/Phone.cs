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
            ValidName = false;
            ValidPhoneNumber = false;
        }

        /// <summary>
        /// Set the name of the contact after validating the fields are formatted
        /// correctly
        /// </summary>
        public string Name
        {
            get { return mFullName; }
            set
            {
                string result = ValidateName(value);
                if (result == "Empty Field."){
                    ValidName = false;
                    ex = new MyFieldException(result, "Name", value);
                }
                else if (result == "Must Include Comma.")
                {
                    ValidName = false;
                    ex = new MyFieldException(result, "Name", value);
                }
                else if (result == "Must have First name following the comma.")
                {
                    ValidName = false;
                    ex = new MyFieldException(result, "Name", value);
                }
                else if (result == "Must have Last name followed by comma.")
                {
                    ValidName = false;
                    ex = new MyFieldException(result, "Name", value);
                }
                else if (result == "Incorrect format.")
                {
                    ValidName = false;
                    ex = new MyFieldException(result, "Name", value);
                }
                else
                {
                    mFullName = result;
                    ValidName = true;
                }
            }
        }

        /// <summary>
        /// Set the phone number of the contact after validating the fields are formatted
        /// correctly
        /// </summary>
        public string PhoneNumber
        {
            get { return mPhoneNumber; }
            set
            {
                string result = ValidatePhoneNumber(value);

                if (result == "Empty Field")
                {
                    ValidPhoneNumber = false;
                    ex = new MyFieldException(result, "Phone Number", value);
                }
                else if (result == "Invalid area code")
                {
                    ValidPhoneNumber = false;
                    ex = new MyFieldException(result, "Phone Number", value);
                }
                else if (result == "Must input 7 or 10 digit")
                {
                    ValidPhoneNumber = false;
                    ex = new MyFieldException(result, "Phone Number", value);
                }
                else
                {
                    mPhoneNumber = result;
                    ValidPhoneNumber = true;
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

        /// <summary>
        /// Checks the Name against set Regex expressions to determine any formatting
        /// issues from user input
        /// </summary>
        public static string ValidateName (string n)
        {
            string name = n.Trim(' '); 
            Regex check = new Regex(@"^[A-Za-z' -]+\s?,\s?[A-Za-z' -]+$");
            Regex checkComma = new Regex(@"(\,)");
            Regex checkLastName = new Regex(@"^[A-Za-z' -]+\s?,*");
            Regex checkFirstName = new Regex(@",\s?[A-Za-z' -]+$");

            if (name == "" || name == null)
            {
                return "Empty Field.";
            }
            else if(check.IsMatch(name))
            {
                return name;
            }
            else if (checkComma.IsMatch(name))
            {
                if (checkLastName.IsMatch(name))
                {
                    if (checkFirstName.IsMatch(name))
                    {
                        return "Incorrect format.";
                    }
                    else
                    {
                        return "Must have First name following the comma.";
                    }
                }
                else
                {
                    return "Must have Last name followed by comma.";
                }
            }
            else
            {
                return "Must Include Comma.";
            }
        }

        /// <summary>
        /// Checks the Phone number set Regex expressions to determine any 
        /// formatting issues from the user input
        /// </summary>
        public static string ValidatePhoneNumber (string pn)
        {
            Regex check = new Regex(@"^((419)?(\s*|-)\d{3}(\s|-)\d{4}|419\d{7}|\d{3}(\s|-)\d{4}|\d{7})$");
            Regex checkLength = new Regex(@"^(\d{3}(\s|-)\d{4}|\d{7})$");
            Regex check419 = new Regex(@"^((?=419)\d{10}$)");
            string phoneNum = pn;
            if (pn == "")
            {
                return "Empty Field";
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
                phoneNum = Regex.Replace(phoneNum, @"[^0-9]", "");
                if (phoneNum.Length == 10)
                {
                    if (check419.IsMatch(phoneNum))
                    {
                        return phoneNum;
                    }
                    else
                    {
                        return "Invalid area code";
                    }
                }
                else
                {
                    return "Must input 7 or 10 digit";
                }
            }
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
