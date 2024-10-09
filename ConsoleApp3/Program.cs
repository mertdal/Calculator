using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, result;
            char symbol;
            Console.WriteLine("Lütfen İlk Sayıyı Giriniz.");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen İkinci Sayıyı Giriniz.");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen gerçekleşmesini istediğiniz işlemi giriniz.");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Sonuç = " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Sonuç = " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Sonuç = " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Sonuç = " + result);
                    break;
                    
            }
            Console.ReadLine();
        }
    }
}
