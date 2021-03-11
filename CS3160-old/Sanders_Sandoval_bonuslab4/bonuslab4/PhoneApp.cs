using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace bonuslab4
{
    // This is the business tier, the fucntions are called by the presentation tier
    // This is the tier that calls the DataAccess tier as needed. Because the methods
    // and data aren't static, the presentation tier needs an object of type PhoneApp
    public class PhoneApp
    {
        private static ArrayList phoneList;    // list of phone, using presentation tier
        private static bool dataModified;      // flag to indicate that data changed
        private static string fileName;         // input/output file name

        static PhoneApp()
        {
            
            phoneList.Capacity = 5;
            dataModified = false;
        }

        // Access data access tier to obtain data
        public ArrayList ReadPhones(string inputFileName)
        {
            Phone ph;
            fileName = inputFileName;
            try
            {
                DataAccess.InitializeRead(fileName);
            }
            catch(System.IO.FileNotFoundException)
            {
                return phoneList;   // return empty list, not an error
            }

            // Now that the file was opened, read the data and store Phone objects in phoneList ArrayList.
            // Call InitializeRead(), FinishRead() as needed
            DataAccess.InitializeRead(inputFileName);

            for (int i=0;i < phoneList.Capacity; i++)
            {
                ph = DataAccess.ReadPhone();
                phoneList[i] = ph;
                
            }

            DataAccess.FinishRead();

            return phoneList;
        }

        // Utilize data access tier to write names/phone numbers to output file.
        // Do not even attempt data access tier connection if not data was modified.
        // Otherwise call InitializeWrite(), WritePhone() for each Phone object, then FinishWrite()

        public void WritePhones()
        {
            
            if (dataModified == true)
            {
                try
                {
                    DataAccess.InitializeWrite("phoneBook.txt");
                }
                catch (System.IO.FileNotFoundException)
                {
                    
                }

                DataAccess.InitializeWrite("phoneBook.txt");

                for (int i = 0; i < phoneList.Capacity; i++)
                {
                    DataAccess.WritePhone((Phone)phoneList[i]);
                }

                DataAccess.FinishWrite();
            }
        }

        // Add new Phone object to the list of Phone objects, set modified flag to true
        public void NewPhone(Phone ph)
        {
            Phone _phone_ = new Phone(ph.Name, ph.PhoneNumber);
            dataModified = true;
        }


    }
}
