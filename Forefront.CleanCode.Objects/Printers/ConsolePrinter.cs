using System;

namespace Forefront.CleanCode.Objects.Printers
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string output)
        {
            Console.Write(output);
        }

        public void PrintLine(string output, params object[] arguments)
        {
            Console.WriteLine(output, arguments);
        }

        public void PrintLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}