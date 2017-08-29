using System;

namespace Module03_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //System.Int32 i;
            //System.Decimal komma;
            //System.Boolean b;

            int i; // normal brugt
            decimal komma; // normal brugt
            double d;
            long l;
            DateTime dato; // normal brugt
            bool b; // normal brugt

            i = 0;
            i = i + 1;

            dato = DateTime.Now;
            DateTime jul = new DateTime(2017, 12, 24);
            System.TimeSpan ts = jul.Subtract(dato);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
