using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Bonus_Delegate
{
    public partial class Form1 : Form
    {

        // TODO declare public delegate type that receives an int and returns a bool
        // call it NumberPredicateType
        public delegate bool NumberPredicateType(int num);


        public Form1()
        {
            InitializeComponent();
        }
        

        private bool IsEven(int n) { return n % 2 == 0; }
        
        private void btnLambda_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
   
            NumberPredicateType evenPredicate = IsEven;

            // TODO call the lambda expression through the declared variable, evenPredicate
            Console.WriteLine("Use a lambda-expression variable to check 4: " + evenPredicate(4));

            
            // TODO create an instance of the NumberPredicateType delegate type using
            // an explicit lambda expression. Check if number passed is even. 
            // Call the variable evenPredicate.
            List<int> evenList = FilterArray(numbers, evenPredicate);
            DisplayList("Even numbers: ", evenList);


            // TODO: filter the odd numbers without declaring a separate predicate variable
            // HINT: use lambda expression, call DisplayList to display results
            evenPredicate = n => n%2 == 1;
            List<int> oddList = FilterArray(numbers, evenPredicate);
            DisplayList("Odd numbers:\t", oddList);

            // TODO: filter numbers > 5 without declaring a separate predicate variable
            // Call DisplayList to display results
            evenPredicate = n => n > 5;
            List<int> greaterList = FilterArray(numbers, evenPredicate);
            DisplayList("Greater than 5:\t", greaterList);
        }

        

        private static List<int> FilterArray(int[] a, NumberPredicateType p) 
        {
            List<int> list = new List<int>();
            for ( int i =0; i < a.Length; i++)
            {
                if (p(a[i]) == true)
                    list.Add(a[i]);
            }
            return list; 
        }
        private static void DisplayList(string label, List<int> nums)
        {
            MessageBox.Show(label + string.Join(" ", nums));
        }

    }
}
