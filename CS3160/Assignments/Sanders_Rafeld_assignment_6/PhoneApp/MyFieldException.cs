using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public class MyFieldException : Exception
    {
        private string errormessage;
        private string fielderror;
        private string userinput;

        public string FieldError
        {
            get { return fielderror; }
            set { fielderror = value; }
        }

        public string UserInput
        {
            get { return userinput; }
            set { userinput = value; }
        }
        public string ErrorMessage
        {
            get { return errormessage; }
            set { errormessage = value; }
        }

        public MyFieldException()
        {
            //constructor
        }

        /// <summary>
        /// Triggered when the program finds a formatting issue from the user input
        /// calls the fieldexectpion form to show the error that was found
        /// </summary>
        public MyFieldException(string message, string error, string input)
        {
            MyFieldException ex = new MyFieldException();
            ex.errormessage = message;
            ex.fielderror = error;
            ex.userinput = input;

            try
            {
                FieldExceptionForm frm = new FieldExceptionForm(ex);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
