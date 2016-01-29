using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Ввести строку");
                object s = Console.ReadLine();
                string temp = s.ToString();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ввести целое число");
                s = Console.ReadLine();
                int i = Convert.ToInt32(s);
                object t = i;
                long bububu = (long)t;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("ВВести дробное число через ,");
                s = Console.ReadLine();
                double d = Convert.ToDouble(s);
                throw new Exception("Я ошибко");
            }
            catch (Exception e) {
                if (e.Message == "Я ошибко")
                {
                    Console.WriteLine("произошла рукотворная ошибка");
                }
                else Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
