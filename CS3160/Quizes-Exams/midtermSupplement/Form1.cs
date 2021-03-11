using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;

namespace midtermSupplement
{
    public partial class Form1 : Form
    {
        private Employee[] mEmployeeList = new Employee[50];
        public Form1()
        {
            InitializeComponent();

            mEmployeeList[0] = new Employee("Bob", "Smith", "bobsmith@gmail.com", 30000);
            mEmployeeList[1] = new Employee("Sid", "Sanders", "sidsanders@gmail.com", 65000);
            mEmployeeList[2] = new Employee("Nick", "Siclair", "nicksiclair@gmail.com", 57000);
            mEmployeeList[3] = new Employee("Hannah", "Grace", "hannahgrace@gmail.com", 60000);
            mEmployeeList[4] = new Employee("Even", "Gardner", "evengerdner@gmail.com", 40000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            foreach(Employee emp in mEmployeeList)
            {
                if (emp != null)
                    lstEmployee.Items.Add(emp.ToString());

            }

            decimal v = calculateAverage();
            txtAvg.Text = v.ToString("C", CultureInfo.CurrentCulture);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //start the new form
            try
            {
                Employee emp = new Employee();
                Form2 newEmp = new Form2();
                if (newEmp.ShowDialog() == DialogResult.OK)
                {
                  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void lstEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstEmployee.SelectedIndex;
            txtEmail.Text = mEmployeeList[index].Email;
            txtSalary.Text = mEmployeeList[index].Salary; 
            
        }

        private decimal calculateAverage()
        {
            decimal total = 0;
            decimal avg = 0;
            int count= 0;            
            foreach(Employee em in mEmployeeList)
            {

                //decimal num = decimal.Parse(em.Salary);
                total += 0;
                count++;
            }
            avg = total / count;
            return avg;
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            if (decimal.Parse(txtSalary.Text) < 0)
            {
                throw new ApplicationException("Invalid Sallary");
            }
            else
            {
                mEmployeeList[lstEmployee.SelectedIndex].Salary = txtSalary.Text;
            }
        }
    }
}
