using C = System.Console;
using Customer;

namespace Main
{
    class App
    {
        static void Main(string[] args)
        {
            int id_int;
            int index;
            

            Customer[] customers;
            customers = CreateCustomers();

            foreach (Customer c in customers)
                C.WriteLine(c);
        }
        static Customer[] CreateCustomers(Customer[] customers)
        {
            customers[0] = Customer("Bill", "Gates",123);
            customers[1] = Customer("Ellon","Musk",456);
            customers[2] = Customer("Jeff","Bezos",789);

            return customers;
        }
    }//class
}//namespace
