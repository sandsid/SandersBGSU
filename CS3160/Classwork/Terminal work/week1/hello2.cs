using C = System.Console;

namespace Example
{
    public class Hello
    {
        static void Main( string[] args )   
        {
            string person = "Anna";

            if (args.Length >= 1)           
                person = args[0];        
            C.WriteLine($"Welcome to C# Programming, {person}!");   
        }
    }
}