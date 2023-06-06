using System;
using System.Threading;
using System.Globalization;//для преобразования форматов с точкой

namespace izuchenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;//сделать консоль зеленой

            //Вывод и ввод информации в консоль
            /*
           Console.WriteLine("ХУЙ");
           Console.WriteLine("пенис");

           string c;
           string w= ("кто я");           
           Console.WriteLine(w);
           c = Console.ReadLine();
           Console.Write("сам ты ");
           Console.WriteLine(c);
             */

            //конвертирование из строки в число

            string a, b, c;
            int aint, bint, cint;
            int d;
            bool variable = true;
            Console.Write("введите значение для парс конвертации   ");
            string dlaparsa = Console.ReadLine();
            int sposobpars = int.Parse(dlaparsa);
            Console.Write("введите значение с разделителем точкой   ");
            string urok = Console.ReadLine();
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double urokd=Convert.ToDouble(urok, numberFormatInfo);
            Console.Write("введите значение a   ");
            a = Console.ReadLine();
            Console.Write("введите значение b   ");
            b = Console.ReadLine();
            Console.Write("введите значение c   ");
            c = Console.ReadLine();
            aint=Convert.ToInt32(a, numberFormatInfo);
            bint = Convert.ToInt32(b, numberFormatInfo);
            cint = Convert.ToInt32(c, numberFormatInfo);
            d = aint + bint + cint;
            Console.WriteLine("Сумма чисел a, b и c ровна " + d);
            double priv = (double)d;
            Console.WriteLine("Сумма чисел a, b и c ровна " + d);
            Console.WriteLine("введено значение с разделителем точкой   " + urokd);
            Console.WriteLine(variable);
            Console.WriteLine("Методом парс конвертировалось число " + sposobpars);
            Thread.Sleep(10000);

        }
    }
}
