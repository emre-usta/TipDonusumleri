using System;

namespace Array_sınıfı_metodları 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion

            byte a = 5;
            sbyte b = 30
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "emre usta";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g:" + g);

            // Explicit Conversion 

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 15.4f;
            byte v = (byte)w;
            Console.WriteLine("w:" + w);

            // ToString 

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);,

            string s1="10", s2="13";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

        }
    }
}