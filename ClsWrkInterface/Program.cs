using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // I want to access these derive classes through interface object reference
            // you can,t create obj 
           // ILog log = new Ilog();
           Console.WriteLine("Insert value ............");
            string input = Console.ReadLine();
            if (input == "console")
            {
                ILog consolelog = new ConsoleLog();
                PassControlIntoInterface pass = new PassControlIntoInterface(consolelog);
                pass.CalculateLog();
            }
            else if(input == "file")
            {
                ILog filelog = new FileLog();
                PassControlIntoInterface pass = new PassControlIntoInterface(filelog);
                pass.CalculateLog();
            }
            else
            {
                Console.WriteLine("you can not save the file into Log");
            }

            

           
            //ILog fileLog = new FileLog();
            //fileLog.Log();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
