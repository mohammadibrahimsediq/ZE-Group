using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Person p1 = new Person() { Name="Tom", Address="10211 Bird Road", SIN="12121212"};
            Person p2 = new Person() { Name="Bob", Address="10211 Bird Road", SIN="14141414"};

            string result;
            result = ComparePerson(p1, p2);
            Console.Write(result);

        }
        static string ComparePerson(Person val1, Person val2)
        {
            if (val1.Name==val2.Name && val1.Address ==  val2.Address && val1.SIN==val2.SIN)
            {
                return "True";
            }
            else {
                return "False";
            }
        }
        
        public class Person
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string SIN { get; set; }
            public int Age { get; set; }
        }
        
    }
}
