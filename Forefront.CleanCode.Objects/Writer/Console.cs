using System;

namespace Forefront.CleanCode.Objects.Writer
{
    public class Console : IPrint
    {
        public void Print(string output)
        {
            System.Console.Write(output);
        }

        public void PrintLine(string output)
        {
            System.Console.WriteLine(output);
        }
    }
}