using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "aLLeN KUO";
            string nameResult = name.ToLower();
            string nameResult2 = nameResult.Substring(0, 1);
            string nameResult3 = nameResult.Substring(6, 1);
            string nameResult4 = nameResult2.ToUpper();
            string nameResult5 = nameResult3.ToUpper();
            string nameResult6 = nameResult.Substring(1, 5);
            string nameResult7 = nameResult.Substring(7, 2);
            string nameResult8 = nameResult4 + nameResult6 + nameResult5 + nameResult7;
            Console.WriteLine(nameResult8); //醜爛抱歉
        }
    }
}
