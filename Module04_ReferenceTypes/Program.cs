namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonStruct p1;
            p1.Id = 1;
            p1.ErILive = true;

            PersonStruct p2 = new PersonStruct();
            p1.Id = 2;
            p1.ErILive = true;

            PersonClass p3;
            p3 = new PersonClass();
            p3.Id = 3;
            System.Console.WriteLine(p3.Id);

            PersonClass p4 = new PersonClass();
            p4.Id = 4;
            p4.ErILive = false;

            p1 = p2; // Kopierer værdier

            p3 = p4; // Kopierer referencer
            System.Console.WriteLine(p3.Id);
            System.Console.WriteLine(p4.Id);

            System.Console.WriteLine();

            p3.Id = 5;
            System.Console.WriteLine(p3.Id);
            System.Console.WriteLine(p4.Id);

            p2.Id = 20;
            System.Console.WriteLine(p1.Id);
            System.Console.WriteLine(p2.Id);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    struct PersonStruct
    {
        public int Id;
        public bool ErILive;
    }

    class PersonClass
    {
        public int Id;
        public bool ErILive;
    }
}
