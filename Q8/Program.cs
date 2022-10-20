using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0935****46
            Console.WriteLine("輸入你的手機號碼");
            string number = Console.ReadLine();

            if (string.IsNullOrEmpty(number) || number.Length != 10) 
            {
                Console.WriteLine("格式錯誤");
                return;
            }
            string encryptednumber = number.Substring(0, 4) + new string('*',4) + number.Substring(8, 2);
            Console.WriteLine(encryptednumber);


        }
    }
}
