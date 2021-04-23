using System;
using System.Collections;
using System.Windows.Forms;

namespace PhoneApp
{
    /// <summary>
    /// This is the business tier.  The functions are called by the
    /// presentation tier.  This is the tier that calls the DataAccess
    /// tier as needed.  Because the methods and data aren't static,
    /// the presentation tier needs an object of type PhoneApp.
    /// </summary>
    public class PhoneApp
    {
        // The ArrayList is used to maintain the list of phones for
        // the presentation tier.
        private static ArrayList mPhoneList;

        // The dataModified value is used to determine if the file
        // needs to be written at the end of the application.
        private static bool mIsModified;

        // input filename from user selection.
        private static string mFileName;

        //output filename
        private static string mOutFileName = "phoneBook.txt";

        static PhoneApp()
        {
            mIsModified = false;
            mPhoneList = new ArrayList();
        }

        public ArrayList ReadPhones(string inputFileName)
        {
            Phone ph;
            mFileName = inputFileName;
            try
            {
                DataAccess.InitializeRead(mFileName);
            }
            catch (System.IO.FileNotFoundException)
            {
                // If the file wasn't found, just return the
                // empty phone list.  This isn't really an error.
                return mPhoneList;
            }
            ph = DataAccess.ReadPhone();
            while (ph != null)
            {
                // Keep reading until no more data.
                mPhoneList.Add(ph);
                ph = DataAccess.ReadPhone();
            }
            DataAccess.FinishRead();
            return mPhoneList;
        }

        public void WritePhones()
        {
            // No need to output anything if the file wasn't modified
            if (mIsModified)
            {
                DataAccess.InitializeWrite(mOutFileName);
                foreach (Phone ph in mPhoneList)
                {
                    DataAccess.WritePhone(ph);
                }
                DataAccess.FinishWrite();
            }
        }

        public void NewPhone(Phone ph)
        {
            // Just take the new Phone object and add it to the
            // phone list.  Set the dataModified flag.
            mPhoneList.Add(ph);
            mIsModified = true;
        }
    }
}

