using System;
using System.Data;
using SimplePwshInterpretorLib;

namespace SimplePwshInterpreterConsole
{
    class Program
    {
        static void SimpleInterpretorExample()
        {
            Console.WriteLine("\nTIP: Type exit to finish.\n");

            var simplePwshInterpretor = new SimplePwshInterpretor();

            while (true)
            {
                Console.Write(">>> ");

                string command = Console.ReadLine().Trim().TrimEnd(';');

                if (command.ToLower() == "exit")
                    break;

                simplePwshInterpretor.AddScript(command);    // not capturing return type.

                DataTable dt = simplePwshInterpretor.Eval();

                string output = dt.ToDataTableString();
                System.Console.WriteLine(output);
            }

            Console.WriteLine("\nFinished ...");
        }

        static void Main(string[] args)
        {
            SimpleInterpretorExample();

            Console.WriteLine("\nPress any key to exit...");
            Console.Read();
        }
    }
}
