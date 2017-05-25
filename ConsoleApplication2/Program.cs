using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        delegate void Operation(int number);
        static void Main(string[] args)
        {
            Operation op1 = num => { Console.WriteLine(num * 2); };
            op1 += num => { Console.WriteLine(num * 3); };

            op1(2);

            Console.Read();
        }


    }
}
