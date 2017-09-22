namespace Module08_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Person o1 = new Person() { Navn = "person xxx" };
                o1.Print();

                Student o2 = new Student() { Navn = "student yyy", StudentId = 1 };
                o2.Print();
                o2.BookEksamen();

                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
    class Person
    {
        public string Navn { get; set; }
        public void Print()
        {
            System.Console.WriteLine("Jeg er en person og hedder '" + this.Navn + "'");
        }
    }

    class Student : Person
    {
        public int StudentId;
        public void BookEksamen()
        {

        }
    }

    class Instruktør : Person
    {

    }

    sealed class HjælpeInstruktør : Instruktør { }
}
