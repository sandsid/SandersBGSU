using C = System.Console;
namespace Example 
{
    public class Add 
    {
        static void Main() 
        {
            int num1, num2;
            C.WriteLine("Enter First Integer: ");
            num1 = int.Parse(C.ReadLine());
            C.WriteLine("Ener Second Integer: ");
            num2 = int.Parse(C.ReadLine());

            //unsure if completed
            C.WriteLine("Larger of the Integers is: "+larger(num1, num2).ToString());

        }

        static int larger(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else 
                return num2;
        }

    }
}