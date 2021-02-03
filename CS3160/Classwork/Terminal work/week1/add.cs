using C = System.Console;
namespace Example 
{
    public class Add 
    {
        static void Main() 
        {
            int num1, num2, sum;
            C.WriteLine("Enter First Integer: ");
            num1 = int.Parse(C.ReadLine());
            C.WriteLine("Ener Second Integer: ");
            num2 = int.Parse(C.ReadLine());

            sum = num1 + num2;

            C.WriteLine($"Sum of Integers: {sum}");

        }
    }
}