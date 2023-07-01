using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucutEndeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Vücutu kitle endeksine hoşgeldiniz.");
            double boy, kilo, endeks;
            Console.Write("Boyunuzu giriniz (Metre cinsinden) : ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu giriniz (kg) : ");
            kilo = Convert.ToDouble(Console.ReadLine());
            endeks = kilo / (boy * boy);
            Console.WriteLine("Vücut kitle endeksiniz : {0}", endeks);

            if (endeks < 18)
            {
                Console.WriteLine("ZAYIFSINIZ");
            }
            else if (endeks <= 25 && endeks >= 18)
            {
                Console.WriteLine("Normal");
            }
            else if (endeks <= 30 && endeks >= 25)
            {
                Console.WriteLine("Kilolu");
            }
            else if (endeks <= 35 && endeks >= 30)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Ciddi obez");
            }
            Console.WriteLine("-------------------------------");

            Console.Read();
        }
    }
}
