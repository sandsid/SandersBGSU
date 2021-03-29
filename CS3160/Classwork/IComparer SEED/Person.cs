using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Person : IComparable
    {
        public int Age { get; set;}
        public string Name { get; set; }
        public Person(string n, int a) { Name = n; Age = a; }
        public override string ToString()
        {
            return Name+" ("+Age.ToString()+")";
        }

        public int CompareTo(object obj)
        {
            return this.Age - ((Person)obj).Age;
        }
    }
}
