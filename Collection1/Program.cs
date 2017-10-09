using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Personer = new List<Person>();
            Personer.Add(new Person() { Id = 1, Navn = "Soren" });
            Personer.Add(new Person() { Id = 3, Navn = "Paul" });
            Personer.Add(new Person() { Id = 8, Navn = "Petra" });

            foreach (var item in Personer)
            {
                Console.WriteLine(item.Navn);
            }

            Dictionary<int, Person> PersonDict = new Dictionary<int, Person>();
            PersonDict.Add(1, new Person() { Id = 2, Navn = "Ginny" });
            PersonDict.Add(2, new Person() { Id = 4, Navn = "Harry" });
            PersonDict.Add(3, new Person() { Id = 6, Navn = "Nevil" });

            Console.WriteLine(PersonDict[2].Navn);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
