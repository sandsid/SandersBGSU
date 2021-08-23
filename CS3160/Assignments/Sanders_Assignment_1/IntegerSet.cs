
using System;
using C = System.Console;
using System.Linq;

namespace SetNS
{
    public class Integerset
    {
        bool[] arr;

        //Constructor with no arguments: Create an empty set
        public Integerset() 
        {
            arr = new bool[51];
        }

        //Overloaded constructor with integer array argument:
        //The elements to be put into the set are found in the 
        //array values. If any value is invalid, print a message 
        //and keep going. 
        public Integerset(int[] array)
        {
            arr = new bool[51];

            foreach(int i in array)
            {
                if (i>= 0 && i <51)
                    arr[i]= true;
                else 
                    C.WriteLine("Invalid number! Must be 0-50!");
            }
        }

        //EmptySet: This member function accepts no arguments 
        //and removes all elements from the set.
        public void EmptySet()
        {
            for (int i =0; i < arr.Length; i++)
                arr[i] = false;
        }

        //InsertFromArray: Accepts an integer array as an argument 
        //and adds each integer element to the set. If any integer 
        //value is invalid, print a message. 
        public void InsertFromArray(int[] array)
        {
            foreach(int i in array)
            {
                if (i> 0 && i <51)
                    arr[i]= true;
                else 
                    C.WriteLine("Invalid number! Must be 0-50!");
            }
        }

        //InsertElement: Adds one integer element to the set. If the 
        //integer is invalid, print a message. 
        public void InsertElement(int num)
        {
            if (num > 0 && num <51)
                arr[num]= true;
            else 
                C.WriteLine("Invalid number! Must be 0-50!");
        }

        //DeleteElement: Removes one integer element from the set. 
        //If the integer argument is invalid, print a message. 
        public void DeleteElement(int num)
        {
            if (num > 0 && num <51)
                    arr[num]= false;
                else 
                    C.WriteLine("Invalid number! Must be 0-50!");
        }   

        //InputSet: Allow elements to be added to the set. Read 
        //integers from the console, one at a time, and add them to 
        //the set. Stop the input when the enter key is pressed. For 
        //invalid integers, print an error message.

        public void InputSet()
        {
            int i = 0;
            bool key = false;
            string line = "";

            do {
                C.Write("Enter number 0-50 (Enter to stop):\t");
                line = C.ReadLine();

                if (string.IsNullOrEmpty(line))
                    key = true;
                else
                {
                    i = int.Parse(line);
                    if (i > 0 && i <51)
                        arr[i]= true;
                    else 
                        C.WriteLine("Invalid number! Must be 0-50!");
                }

            }while (key == false);
        }

        //Union: Calculate the union of the set with another set. An 
        //IntegerSet is an argument to the function, and the function 
        //returns an IntegerSet.
        public Integerset Union(Integerset a)
        {
            int[] temp = new int[51];
            int x = 1;
            for (int i = 1; i < 51; i++)
            {
                if ((this.arr[i] == true || (a.arr[i] == true)))
                {
                    temp[x] = i;
                    x++;
                }
            }
            Integerset b = new Integerset(temp);
            return b;
        }

        //Intersection: Calculate the intersection of the set with 
        //another set.
        public Integerset Intersection(Integerset a)
        {
            int[] temp = new int[51];
            int x = 0;
            for (int i = 0; i < 51; i ++)
            {
                if ((this.arr[i] == true && (a.arr[i] == true)))
                {
                    temp[x] = i;
                    x++;
                }
            }
            Integerset b = new Integerset(temp);
            return b;
        }

        //Equals: Override Equals to determine if the set is equal to 
        //another set (i.e., contains the same elements). This function 
        //requires the override keyword and returns a bool value.
        public override bool Equals(Object obj)
        {
            if ((obj == null) || (!(obj is Integerset)))
                return false;

            Integerset other =(Integerset)obj;
            bool e = true;
            int i = 0;

            do {
                if (this.arr[i] != other.arr[i])
                    e = false;
                i++;
            }while (i < 51 && e == true);

            return e;
        }

        //GetHashCode: This function must be overridden whenever Equals 
        //is overridden. You can return some constant integer value.
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        //ToString: Override the ToString method to return a string 
        //representing the set, using the format { 12 15 30 }. If the 
        //set is empty, return string literal "{ <empty> }".
        public override string ToString()
        {
            int[] temp = new int[51];
            int x = 0;

            for(int i = 0; i < 51; i++)
            {
                if(this.arr[i] == true)
                {
                    temp[x] = i;
                    x++;
                }
            }

            int[] temp2 = new int[x];

            for (int i = 0; i < x; i++)
                temp2[i] = temp[i];

            string output = String.Join(", ", temp2.Select(q=>q.ToString()).ToArray());

            if (x == 0)
                return "{ <empty> }";
            else    
                return $"{{ {output} }}";

        }

        
    }
}