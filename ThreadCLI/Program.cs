using System;

namespace ThreadCLI
{
    class Program
    {
        private static Application app;

        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 43);
            app = new Application();

            var dataFile = args[0];

            app.Run(dataFile);
            Console.WriteLine("Program executed successfully");
            Console.ReadLine();
        }
    }
}