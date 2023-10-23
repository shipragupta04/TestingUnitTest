using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static TestingUnitTest.BasicMaths;


namespace TestingUnitTest
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            Console.Write("enter first number");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter Second number");
            var y = Convert.ToDouble(Console.ReadLine());
            var bm = new BasicMaths();
            Console.WriteLine(bm.Add(x, y));


        }
    }
}
