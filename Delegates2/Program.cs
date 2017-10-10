using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            //m.Log += AppendLog;
            //m.Log += delegate (string s) { System.IO.File.AppendAllText(@"c:\temp\log.txt", s + "\r\n"); };
            m.Log += s => System.IO.File.AppendAllText(@"c:\temp\log.txt", s + "\r\n"); // delta function that does the same as AppendLog()
            m.Start();
            m.Stop();
        }
        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt",txt+"\r\n");
        }
    }
    //public delegate void LogDelegate(string txt); // #
    class Maskine
    {
        //public LogDelegate Log { get; set; } // #
        public Action<string> Log { get; set; } // erstatter #
        public void Start()
        {
            Log(DateTime.Now.ToLongTimeString() + " Starter");
        }
        public void Stop()
        {
            Log(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }
}
