using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Кит плавает под водой со скоростью 27 км/ч. Он развивает мощность 150 кВт. Определить силу сопротивления воды.");
                        double v = 27;
                        double N = 150;
                        Console.WriteLine($"переводим скорость={v * 1000 / 3600}");
                        Console.WriteLine(v);
                        Console.WriteLine($"переводим мощность={N * Math.Pow(10, 3)}");
                        Console.WriteLine(N);
                        Console.WriteLine($"{N / v}");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Посчитайте, сколько очков набрала команда «Динамо» в первом круге чемпионата России по хоккею, если известно, что m встреч она выиграла, n встреч проиграла, k встреч закончились ничьими, полагая, что за выигрыш команда получает 2 очка, за ничью 1 очко, за проигрыш – 0 очков.");
                        Console.Write("Введите кол-во выигравшей команды Динамо=");
                        int m = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите кол-во проигравших встреч=");
                        int c = int.Parse(Console.ReadLine());
                        Console.Write("Введите кол-во ничьих встреч команд=");
                        int k = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Очки команды Динамо:{(m * 2) + (k * 1) + (c * 0)}");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Вычислить значение функции для заданного значения аргумента");
                        Console.Write("Введите x=");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("Введите h=");
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine($"y={h * 2 * x + (Math.Sin(3) * x + 1) / (2 * (Math.Sqrt(Math.Exp(3) + 1) - (Math.Cos(x - Math.PI))))}");
                        Console.ReadKey();
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("а^4, а^12, а^28 за шесть операций, а – действительное число, при этом не пользуясь никакими другими арифметическими операциями, кроме умножения.");
                        Console.Write("Введите а=");
                        double a = double.Parse(Console.ReadLine());
                        double b = a * a * a * a;
                        Console.WriteLine($"a^4={b}");
                        double c = b * a;//a^5
                        Console.WriteLine($"a^5={c}");
                        double e = c * c * c * c;//a^20
                        double f = b * b;//a^8
                        double g = f * c;
                        Console.WriteLine($"a^28={g}");
                        Console.ReadKey();
                    }
                    break;
                default:
                    {
                        Console.Write("Такого задания нет");
                    }
                    break;
            }
        }
    }
    
}
