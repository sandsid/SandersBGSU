using C = System.Console;
namespace Example 
{
    public class ToBe 
    {
        static void Main ()
        {
            string[] hamlet = {"To be", "or not", "to be"};

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