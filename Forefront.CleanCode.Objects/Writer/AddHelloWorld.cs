using System;

namespace Forefront.CleanCode.Objects.Writer
{
    public class AddHelloWorld : IPrint
    {
        public void Print(string output)
        {
            System.Console.Write("{0} hello world ", output);
        }

        public void PrintLine(string output)
        {
            System.Console.Write("{0} hello world ", output);
        }
    }
}