using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = Convert.ToUInt16(Console.ReadLine());
            int result;
            if (key % 2 == 0)
            {
                result = key * key;
            }
            else {
                result = key * key * key;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}