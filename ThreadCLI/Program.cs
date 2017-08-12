using System;

namespace ThreadCLI
{
    class Program
    {
        private static Application app;

        static void Main(string[] args)
        {
            app = new Application();

            var dataFile = args[0];

            app.Run(dataFile);

            Console.WriteLine("Program executed successfully");
            Console.ReadLine();
        }
    }
}