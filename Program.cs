using System;
using System.Management.Automation;

namespace SimplePwshInterpretor
{
    class Program
    {
        static PowerShell GetPowerShell()
        {
            PowerShell ps = null;

            try
            {
                ps = PowerShell.Create();
            }
            catch (Exception ex)
            {
                Console.WriteLine("!!!ERROR!!!");
                Console.WriteLine("No cookies for you.");
                Console.WriteLine("Is Powershell 7 installed in your system?");
                Console.WriteLine("Logging error as :-");
                
                Console.WriteLine(ex);

                Console.WriteLine("");

                Console.WriteLine("Exiting to OS with exit code -1");
                Environment.Exit(-1);
            }

            return ps;
        } 


        static void SimpleInterpretor()
        {
            Console.WriteLine("\nTIP: Type exit to finish.\n");

            PowerShell ps = GetPowerShell();

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
                Console.WriteLine("\nProgram terminating with Exception:\n" + ex);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.Read();
        }
    }
}
