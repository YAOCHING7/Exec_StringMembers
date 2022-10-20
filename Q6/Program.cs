using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "Allen";
            Console.WriteLine("請輸入Allen");
            string input = Console.ReadLine();
            bool result1 = value == input;
            Console.WriteLine(result1);
        }
    }
}
