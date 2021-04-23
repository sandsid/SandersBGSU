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
        private MyFieldException ex;

        public string FieldError
        {
            get { return fielderror; }
        }

        public string UserInput
        {
            get { return userinput; }
        }
        public string ErrorMessage
        {
            get { return errormessage; }
        }
        public MyFieldException(string message, string error, string input)
        {
            //ex = new MyFieldException(message, error, input);
            ex.errormessage = message;
            ex.fielderror = error;
            ex.userinput = input;
            
            //try
            //{
            //    FieldExceptionForm frm = new FieldExceptionForm(ex);
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
                    
            //    }
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
