using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            w.Changed += (c, n) => Console.WriteLine("Filen " + n.Name + " er rettet");
            w.Deleted += (s,e) => Console.WriteLine("Filen " + e.Name + " er slettet");
            w.Created += W_Created;
            //do
            //{

            //} while (true);
            Console.ReadKey();
        }

        private static void W_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen " + e.Name + " er skabt");
        }
    }
}
