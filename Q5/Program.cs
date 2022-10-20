using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "Allen";
            string value2 = value.ToLower();
            Console.WriteLine("請輸入Allen");
            string input= Console.ReadLine();
            string result= input.ToLower();
            bool result1 = value2 == result;
            Console.WriteLine(result1);

        }
        
    }
}
