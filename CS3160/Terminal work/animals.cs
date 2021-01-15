using C = System.Console;
namespace Example 
{
    public class Animals 
    {
        static void Main() 
        {
            string animals;
            int cats = 100;
            int dogs = 2;
            // Create animals string containing "cats = XX and dogs = YY"
            // using string interpolation
            animals = $"cats = {cats} and dogs = {dogs}";

            C.WriteLine(animals);

        }
    }
}