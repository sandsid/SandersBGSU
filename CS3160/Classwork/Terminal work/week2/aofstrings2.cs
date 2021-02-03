using C = System.Console;
namespace Example 
{
    public class ToBe 
    {
        static void Main ()
        {
            C.WriteLine("Enter number os strings to allocate: ");
            int numItems = int.Parse(C.ReadLine());
            


            string[numItems] ary;

            //print the array to the console
            Print(hamlet);
        }

        static void Print ( string[] hamlet)
        { 
            for (int i = 0; i < hamlet.Length; i++)
            {
                C.WriteLine(hamlet[i]);
            }
        }

    }
}