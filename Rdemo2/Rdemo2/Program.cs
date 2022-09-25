using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Logger = new FileLogger();
            //customerManager.Logger = new SmsLogger();
            //customerManager.Logger = new ILogger();
            CustomerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
    {
        Console.WriteLine("Customer is Added!");
     }
}
    class  DatabaseLogger: ILogger
    {
        Console.WriteLine("DatabaseLogger is Added!");
    }
    class SmsLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to SMS!...");
        }
  
            }


   public void Log()
        {
        DatabaseLogger Logger = new DatabaseLogger();
         Logger logger = new Logger();
          Logger.log();
     
            Console.WriteLine("Logged to Database!");
        }
    }
    class FileLogger : ILogger
    {
        Console.WriteLine("Logged to File!");
    }
    interface ILogger
    {
        void Log();
    }
}
