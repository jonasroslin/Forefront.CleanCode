using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forefront.CleanCode.Methods.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int foo = Foo(5, 10, true);
        }

        public static int Foo(int bar, int baz, bool useAddition)
        {
            int result;
            if (useAddition)
            {
                result = bar + baz;
            }
            else
            {
                result = bar - baz;
            }

            return result;
        }
    }
}
