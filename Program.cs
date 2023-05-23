using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lyakhov_lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////task 1a
            //Console.Write("Введите строку: ");
            //string input = Console.ReadLine();

            //string pattern = "abcd2023111111102023"; 
            //if (Regex.IsMatch(input, pattern))
            //{
            //    string result = input.Replace("2023", "happy new year"); 
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Введенная строка не соответствует шаблону.");
            //}

            ////task 1b
            //Console.Write("Введите строку: ");
            //string input = Console.ReadLine();
            //string pattern = @"\d+";
            //MatchCollection matches = Regex.Matches(input, pattern);
            //List<int> numbers = new List<int>();
            //foreach (Match match in matches)
            //{
            //    int number = int.Parse(match.Value);
            //    numbers.Add(number);
            //}

            //Console.WriteLine("Числа: " + string.Join(", ", numbers));
            //Console.WriteLine("Сумма: " + numbers.Sum());
            //Console.WriteLine("Максимальное число: " + numbers.Max());
            //Console.WriteLine("Порядковый номер максимального числа: " + (numbers.IndexOf(numbers.Max()) + 1));

            //task 1с
            //Console.WriteLine("Введите строку с десятичными числами:");
            //string input = Console.ReadLine();

            //Regex regex = new Regex(@"[-+]?\d+(\.\d+)?");
            //MatchCollection matches = regex.Matches(input);

            //Console.WriteLine("Десятичные числа:");
            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.Value);
            //}

            //string replaced = regex.Replace(input, "number");

            //Console.WriteLine("Строка с замененными десятичными числами: " + replaced);
            
            
            Console.ReadLine();
        }
    }
}
