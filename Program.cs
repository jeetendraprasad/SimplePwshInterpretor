using System;
using System.Management.Automation;

namespace SimplePwshInterpretor
{
    class Program
    {
        static void SimpleInterpretor()
        {
            Console.WriteLine("TIP: Type exit to finish.\n");

            PowerShell ps = PowerShell.Create();

            while (true)
            {
                Console.Write(">>> ");

                string command = Console.ReadLine().Trim().TrimEnd(';');

                if (command.ToLower() == "exit")
                break;

                ps.AddScript(command);

                var results = ps.Invoke();

                foreach(var result in results)
                {
                    Console.WriteLine(Convert.ToString(result));
                }
            }
            

        }


        static void Main(string[] args)
        {
            try
            {
                SimpleInterpretor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Program terminating with Exception:\n" + ex);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.Read();
        }
    }
}
