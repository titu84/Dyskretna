using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun
{
    class Program

    {
        static void Main(string[] args)
        {
            //Console.WriteLine(rozwiazanieCalkowite(3,9,191));
            Console.WriteLine(wspolnyZbior(77,42,20));
            //Console.WriteLine(dzielniki(10010));
            //Console.WriteLine(podzbiory(3, 8));
            //Console.WriteLine(podzbioryMulti(3, 3));
            //Console.WriteLine(podzbiory(9));
            //Console.WriteLine(KrawedzieGrafu(8));
            //Console.WriteLine(nwd(2002,770));
            //Console.WriteLine(ileF(3,5));
            //Console.WriteLine(ileFR(4,6));
            //Console.WriteLine(mocJednowartosciowa(6));
            int i = 0;
            while (i < 10)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("*" + Funkc(n).ToString() + "*");
                i++;
            }
            Console.ReadKey();
        }
        //Oblicz, ile jest funkcji wzajemnie jednoznacznych f:A→A,  jeśli moc zbioru A wynosi 6
        static long mocJednowartosciowa(int x)
        {
            return silnia(x);
        }
        //ile funckji rożnowartosciowych
        static long ileFR(int m, int w)
        {
            return silnia(w) / silnia(w - m);
        }
        //ile funckji 
        static double ileF(int m, int w)
        {
            return Math.Pow(w, m);
        }
        //Ustal, co zwraca poniższa funkcja rekurencyjna dla wartości 6, 7, 8
        static int Funkc(int n)
        {
            if (n < 2) return n;
            if (n % 2 == 1) return Funkc(n/2)+1;
            else return Funkc(n - 1);
        }
        // Stosując algorytm euklidesa, oblicz największy wspólny dzielnik liczb ... oraz ...
        static int nwd(int a, int b)
        {
            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
        // Oblicz ile jest .k.-elementowych podzbiorów zbioru .n.-elementowego
        static long podzbiory(int k, int n)
        {
            if (n < k)
            {
                Console.WriteLine("zbiory musibyc wieksze od podzbiory");
            }
            long g = silnia(n);
            long d = silnia(k) * silnia(n - k);
            return g / d;
        }
        static long podzbioryMulti(int k, int n)
        {
            if (n < k)
            {
                Console.WriteLine("zbiory musibyc wieksze od podzbiory");
            }
            long g = silnia(n+k-1);
            long d = silnia(k) * silnia(n - 1);
            return g / d;
        }
        static long silnia(int n)
        {
            if (n < 2)
                return 1;
            return n * silnia(n - 1);
        }
        //Oblicz, ile jest wszystkich podzbiorów zbioru ...-elementowego?
        static Double podzbiory(int k)
        {
            return Math.Pow(2, k);
        }
        //Podaj, ile jest dzielników naturalnych liczby ...
        static int dzielniki(int a)
        {
            int result = 0;
            for (int i = 1; i <= a; i++)           
                result += a % i == 0 ? 1 : 0;         
            return result;
        }
        static int wspolnyZbior(int max, int zbior, int czescwspolna)
        {
            return max - zbior + czescwspolna;            
        }
        //2x + 4y = 191
        static bool rozwiazanieCalkowite(int przyX, int przyY, int wynik)
        {
            return wynik % nwd(przyX,przyY) == 0;
        }
        //ile krawędzi ma graf pełny k8
        static int KrawedzieGrafu(int ile)
        {
            return (ile * (ile - 1)) / 2;
        }
    }
}
