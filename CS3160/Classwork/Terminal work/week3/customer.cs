using C = System.Console;

namespace Customer
{
    public class Customer
    {
        public string firstName;
        public string lastName;
        public int id;
        public Customer (string fn, string ln, string idnum)
        {
            firstName = fn;
            lastName = ln;
            id = idnum;
        }
        public override string ToString()
        {
            string line = "";
            line = $"{firstName} {lastName} ID: {id}";
            return line;
        }
        public override bool Equals(object someObj)  
        {    
            Customer  anotherCust;    
            if ((someObj == null) || !(someObj is Customer))      
                return false;  
            // definitely not equal   
            anotherCust = (Customer)someObj;    // type-cast to access id    
            return this.ID == anotherCust.id;   // equal if same id...  }
        }

        public override int GetHashCode()
        {   
            // delegate hash code computation to underlying integer class...  
            return this.ID.GetHashCode();
        }
        public int GetLength()
        {
            return firstName.length + lastName.length;
        }
    }
}