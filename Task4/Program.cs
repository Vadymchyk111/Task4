using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string zodiacSign;
            string age;

            Console.WriteLine("Как вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Какой ваш знак Зодиака?");
            zodiacSign = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            age = Console.ReadLine();
            Console.WriteLine("Вас зовут - "+name+", вам "+age+" лет, ваш знак зодиака - "+zodiacSign);
        }
    }
}
