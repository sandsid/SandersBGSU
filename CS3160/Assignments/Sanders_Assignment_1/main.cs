

using C = System.Console;
using SetNS;

namespace MainNS
{
    public class App
    {
        static void Main()
        {
            C.WriteLine("// create A by passing an array of integers to overloaded constructor");
            int[] myary = {1, 2, 3, 4};
            
            Integerset A = new Integerset(myary);

            //checks error
            A.InsertElement(99);
            
            C.WriteLine("A is:\t" + A);

            // create new B set
            C.WriteLine("// create B by adding one element at a time");
            Integerset B = new Integerset();
            
            B.InsertElement(31);
            B.InsertElement(42);
            B.InsertElement(11);
            B.InsertElement(21);
            B.InsertElement(29);

            C.WriteLine($"B is:\t{B}");

            //check intersection 
            C.WriteLine("Intersection of A and B is:\t" + A.Intersection(B) + "\n");

            //unit sets 
            C.WriteLine("Union of A and B is:\t" + A.Union(B));

            //testing if equal
            C.WriteLine("// Is a equal to B?");
            if (A.Equals(B))
                C.WriteLine("Set A and B are equal.");
            else 
                C.WriteLine("Set A and B are NOT equal.");

            //copy a to b
            C.WriteLine("Copy A to B.");
            
            B = new Integerset(myary);

            //testing if equal
            C.WriteLine("// Is a equal to B?");
            if (A.Equals(B))
                C.WriteLine("Set A and B are equal.");
            else 
                C.WriteLine("Set A and B are NOT equal.");

            //add element to A
            A.InsertElement(35);
            C.WriteLine("// Insert 35 into A.");
            C.WriteLine("A is:\t" + A);

            //Delete the element
            C.WriteLine("// Delete 35 into A.");
            A.DeleteElement(35);
            C.WriteLine("A is:\t" + A);

            //create set C
            C.WriteLine("// Enter elements into set C");
            Integerset Cset = new Integerset();
            Cset.InputSet();
            C.WriteLine($"C is:\t{Cset}");

            //clear the set C
            C.WriteLine("// Clear set C.");
            Cset.EmptySet();
            C.WriteLine($"C is:\t{Cset}");

        }
    }
}