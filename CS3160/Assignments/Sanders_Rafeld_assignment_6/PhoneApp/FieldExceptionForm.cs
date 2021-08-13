using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class FieldExceptionForm : Form
    {
        public MyFieldException ex;
        public FieldExceptionForm(MyFieldException exec)
        {
            //
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            ex = exec;
            
        }

        /// <summary>
        /// Displays the error to the user 
        /// </summary>
        private void FieldExceptionForm_Load(object sender, EventArgs e)
        {
            txtMessage.Text = ex.ErrorMessage;
            txtField.Text = ex.FieldError;
            txtValue.Text = ex.UserInput;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}
