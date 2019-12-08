using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun
{
    /// <summary>
    /// Klasa umożliwia obliczenie wyników dla kilku probelmów występujących w matematyce dyskretnej
    /// </summary>
    public class ZadaniaMatematykiDyskretnej
    {
        /// <summary>
        /// Pytanie: Podaj, ile jest dzielników naturalnych liczby ...
        /// </summary>
        /// <param name="a">Liczba z której będzie obliczany dzielnik</param>
        /// <returns></returns>
        public int Dzielniki(int a)
        {
            int result = 0;
            for (int i = 1; i <= a; i++)
                result += a % i == 0 ? 1 : 0;
            return result;
        }
        
        /// <summary>
        /// Pytanie: Oblicz, ile jest funkcji wzajemnie jednoznacznych f:A→A,  jeśli moc zbioru A wynosi ...
        /// </summary>
        /// <param name="x">Parametr wejściowy - nie wpisuj bardzo dużych</param>
        /// <returns></returns>
        public long IleFunkcjiWzajemnieJednoznacznych(int x)
        {
            return silnia(x);
        }       
        
        /// <summary>
        /// Pytanie: Ile krawędzi ma graf pełny K...
        /// </summary>
        /// <param name="ile">Ilość krawędzi grafu, np. dla grafu k8 wartość parametru to 8</param>
        /// <returns></returns>
        public int KrawedzieGrafu(int ile)
        {
            return (ile * (ile - 1)) / 2;
        }

        /// <summary>
        /// Pytanie: Oblicz, ile jest wszystkich podzbiorów zbioru k-elementowego?
        /// </summary>
        /// <param name="k">Ile elementów posiada zbiór</param>
        /// <returns></returns>
        public long Podzbiory(int k)
        {
            return (long)Math.Pow(2, k);
        }
        
        /// <summary>
        /// Pytanie: Oblicz ile jest .k.-elementowych podzbiorów zbioru .n.-elementowego
        /// </summary>
        /// <param name="k">Ilość elementów w podzbiorze</param>
        /// <param name="n">Ilość elementów w zbiorze</param>
        /// <returns></returns>
        public long Podzbiory(int k, int n)
        {
            if (n < k)
            {
                Console.WriteLine("ilość zbiorów musi być wieksza niż ilość podzbiorów");
            }
            long g = silnia(n);
            long d = silnia(k) * silnia(n - k);
            return g / d;
        }

        /// <summary>
        /// Pytanie: Oblicz największy wspólny dzielnik liczb a oraz b.
        /// Metoda działa dobrze dla liczb całkowitych większych od zera
        /// </summary>
        /// <param name="a">Dla wartości mniejszych od zera otrzymamy wynik -1</param>
        /// <param name="b">Parametr nie może być zerem, w przypadku 0 otrzymamy wynik -1</param>
        /// <returns></returns>
        static int NajwiekszyWpolnyDzielnik(int a, int b)
        {
            if (b == 0 || a < 0)
            {
                return -1;
            }
            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
        /// <summary>
        /// Lokalna metoda obliczająca silnię. Obliczenia realizowane są za pomocą rekurencji
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        long silnia(int n)
        {
            if (n < 2)
                return 1;
            return n * silnia(n - 1);
        }
    }
}
