using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bonuslab4
{
    public class DataAccess
    {
        // Data Access tier, responsible for all file input and output
        // Other tiers need not be concerned with whether the data is in
        // a text file, database, or other format

        private static StreamReader sr = null;
        private static StreamWriter sw = null;

        public static void InitializeRead(string fileName)
        {
            sr = new StreamReader(fileName);
        }

        // Read one name and phone number from input file. If name == null, return nullptr.
        // If input file not properly opened, throw ApplicationException with:
        // "Input file not open". Otherwise return newly allocated object of type Phone

        public static Phone ReadPhone()
        {
            string n;
            string num;
            Phone ph = null;

            if(sr == null)
            {
                throw new ApplicationException("Input file not open");
            }
            else
            {
                n = sr.ReadLine();
                num = sr.ReadLine();
                ph = new Phone(n, num);
            }
            return ph;
            
        }

        // Close input file
        public static void FinishRead()
        {
            sr.Close();
        }
        // Create new StreamWriter object, utilize given filename
        public static void InitializeWrite(string fileName)
        {
            sw = new StreamWriter(fileName);
        }

        // Write given Phone object to file, name and number on separate lines
        // If output file not properly open, throw APplicationException "Output file not open"
        public static void WritePhone(Phone ph)
        {
            if(sw == null)
            {
                throw new ApplicationException("Output file not open");
            }
            else
            {
                sw.WriteLine(ph.Name);
                sw.WriteLine(ph.PhoneNumber);
            }
        }

        // Close output file
        public static void FinishWrite()
        {
            sw.Close();
        }
       

    }
}
