using System;

namespace Dodatni_zadaci_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dodatni zadaci 4, zadatak 2");
            // 2. Sin ima 9 godina, a otac ima 35 godina. Napraviti funkciju koja će da računa posle koliko
            // godina će otac biti tačno 3 puta stariji od sina. U glavnom programu pozvati funkciju.
            Zad2(35, 9);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 3");
            // 3.Napisati funkciju koja vraća srednju vrednost niza. U glavnom programu pozvati funkciju.
            // vec radjeno u vezbi 10
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 4");
            // 4. Napisati funkciju koja vraća sumu svakog trećeg broja u nizu. U glavnom programu
            // pozvati funkciju.
            int[] nizZad4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumaSvakogTrecegBroja = 0;
            Zad4(ref sumaSvakogTrecegBroja, nizZad4);
            Console.WriteLine($"Suma svakog treceg broja niza iznosi {sumaSvakogTrecegBroja}");
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 5");
            // 5. Napraviti funkciju koja vraća zbir najmanjeg i najvećeg člana niza. U glavnom programu
            // pozvati funkciju.
            int zbirZad5 = 0;
            Zad5(ref zbirZad5, nizZad4);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 6");
            // 6. Napisaiti funkciju koja vraća sortirani niz od najvećeg ka najmanjem. U glavnom
            // programu pozvati funkciju
            int[] sortiraniNizZad6 = new int[10];
            Zad6(nizZad4, ref sortiraniNizZad6);
            foreach (int item in sortiraniNizZad6)
                Console.WriteLine(item);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 7");
            // 7. Napisati funkciju koja za uneta 2 broja radi: sabiranje, oduzimanje, množenje i deljenje. U
            // glavnom programu pozvati funkciju.
            Zad7(2, 2);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 8");
            // 8. Napisati funkciju koja vraća razliku parnih i neparnih brojeva niza. U glavnom programu
            // pozvati funkciju.
            // ovo radim kao suma parnih brojeva niza - suma neparnih brojeva niza
            Zad8(nizZad4);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 9");
            // 9. Napisati funkciju koja ispisuje naziv dana u zavisnosti od broja koji korisnik unese. (3=>
            // sreda). U glavnom programu pozvati funkciju.
            Zad9(3);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 10");
            //10. Generiše se niz od n brojeva u intervalu (1-15). Na početku programa korisnik bira jednu
            // od četiri opcija: 1.Izračunati sumu niza, 2.Najveći član niza, 3.Najmanji člana niza,
            // 4.Prosek generisanog niza. Svaku opciju rešiti pomoću funkcija.U glavnom programu
            // pozvati funkcije.
            Zad10(4, nizZad4);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 11");
            // 11. Napisati funkciju koja prima 3 broja i vraća najveći. U glavnom programu pozvati tu
            // funkciju
            Zad11(1, 2, 3);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 12");
            // 12. Napisaiti funkciju koja pretvara minute u sate i minute (65min = 1h 5min). U glavnom
            // programu pozvati funkciju.
            Zad12(30);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 13");
            // 13. Napisati funkciju koja vraća zbir parnih članova niza nasumičnih brojeva od 1 do 20.
            // Korisnik treba da unese dužinu niza. U glavnom programu pozvati funkciju.
            Zad13(20);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 14");
            // 14. Napisati funkciju koja ispisuje svaki treći broj niza nasumičnih brojeva od 1 do 100. U
            // glavnom programu pozvati funkciju
            Zad14();
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 15");
            // 15. Napisati funkciju koja ispisuje prvi i poslednji član niza. U glavnom programu pozvati
            // funkciju.
            Zad15(nizZad4);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 16");
            // 16. Napisati funkciju koja vraća srednju vrednost brojeva manjih od 15 i većih od 35 iz niza
            // x[20] nasumičnih brojeva(1 - 50). Ispisati te brojeve i njihovu srednju vrednost.U glavnom
            // programu pozvati funkciju
            Zad16();
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 17");
            // 17. Napisati funkciju koja vraća zbir niza, dužinu niza i srednju vrednost indeksa niza
            // nasumičnih brojeva(1 - 20). Korisnik određuje dužinu niza. Ispisati niz i tražene vrednosti.
            // U glavnom programu pozvati funkciju.
            Zad17(10);
            dalje();

            Console.WriteLine("Dodatni zadaci 4, zadatak 18");
            // 18. Napisati funkciju koja vraća koliko se puta koji broj pojavio u nizu x[20] nasumičnih
            // brojeva od 1 do 10.U glavnom programu pozvati funkciju.
            Zad18();
            dalje();
            // Sto se tice prve godine programiranja Petar OUT

        }
        static void dalje()
        {
            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();
        }
        static void Zad2(int a, int b)
        {
            int brojac = 0;
            while (a != b * 3)
            {
                a++;
                b++;
                brojac++;
            }

            Console.WriteLine($"posle {brojac} godina ce otac biti tri puta stariji od sina");

        }
        static void Zad4(ref int a, int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                if (i % 3 == 0)
                    a += b[i];
            }
        }
        static void Zad5(ref int a, int[] b)
        {
            int min = b[0], max = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] < min)
                    min = b[i];
                if (b[i] > max)
                    max = b[i];
            }
            a = max + min;
            Console.WriteLine($"Zbir najmanjeg i najveceg clana niza iznosi {a}");
        }
        static void Zad6(int[] a, ref int[] b)
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = i + 1; j < a.Length; j++)
                {
                    int kucica;
                    if (a[i] < a[j])
                    {
                        kucica = a[i];
                        a[i] = a[j];
                        a[j] = kucica;
                    }
                }
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
        }
        static void Zad7(int a, int b)
        {
            int sabiranje, oduzimanje, mnozenje, deljenje;
            sabiranje = a + b;
            oduzimanje = a - b;
            mnozenje = a * b;
            deljenje = a / b;
            Console.WriteLine($"Zbir dva broja iznosi: {sabiranje}, razlika dva broja iznosi: {oduzimanje}, mnozitak dva broja iznosi: {mnozenje}, deljitak dva broja iznosi: {deljenje}");
        }
        static void Zad8(int[] a)
        {
            int sumaParni = 0, sumaNeparnih = 0;
            foreach (int item in a)
            {
                if (item % 2 == 0)
                    sumaParni += item;
                else
                    sumaNeparnih += item;
            }
            Console.WriteLine($"razlika parnih i neparnih brojeva niza iznosi: {sumaParni - sumaNeparnih}");
        }
        static void Zad9(int a)
        {
            switch (a)
            {
                case 1: Console.WriteLine("Ponedeljak"); break;
                case 2: Console.WriteLine("Utorak"); break;
                case 3: Console.WriteLine("Sreda"); break;
                case 4: Console.WriteLine("Cetvrtak"); break;
                case 5: Console.WriteLine("Petak"); break;
                case 6: Console.WriteLine("Subota"); break;
                case 7: Console.WriteLine("Nedelja"); break;
                default: Console.WriteLine("Unesite broj od 1 do 7"); break;
            }
        }
        static void Zad10(int a, int[] b)
        {
            switch (a)
            {
                case 1:
                    int sumaNiza = 0;
                    foreach (int item in b)
                    {
                        sumaNiza += item;
                    }
                    Console.WriteLine($"Suma niza iznosi: {sumaNiza}");
                    break;
                case 2:
                    int maxNiza = b[0];
                    foreach (int item in b)
                    {
                        if (item > maxNiza)
                            maxNiza = item;
                    }
                    Console.WriteLine($"Najveci clan niza ima vrednost: {maxNiza}");
                    break;
                case 3:
                    int minNiza = b[0];
                    foreach (int item in b)
                    {
                        if (item < minNiza)
                            minNiza = item;
                    }
                    Console.WriteLine($"Najmanji clan niza ima vrednost: {minNiza}");
                    break;
                case 4:
                    decimal prosekNiza = 0;
                    foreach (int item in b)
                    {
                        prosekNiza += (decimal)item;
                    }
                    prosekNiza /= b.Length;
                    Console.WriteLine($"Prosek clanova niza iznosi: {prosekNiza}");
                    break;
                default: Console.WriteLine("Uneli ste nepostojecu opciju"); break;
            }
        }
        static void Zad11(int a, int b, int c)
        {
            if (a >= b && a >= c)
                Console.WriteLine($"najveci broj je {a}");
            else if (b > a && b >= c)
                Console.WriteLine($"najveci broj je {b}");
            else
                Console.WriteLine($"najveci brj je {c}");
        }
        static void Zad12(int a)
        {
            int sati = 0, minuti = 0;
                while (a > 60)
                {
                    sati++;
                    a -= 60;
                }
            minuti = a;
            Console.WriteLine($"Unet broj predstavlja {sati} - sati i {minuti} - minuta");
        }
        static void Zad13(int a)
        {
            int[] niz = new int[a];
            Random rand = new Random();
            int zbir = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rand.Next(20);
                zbir += niz[i] % 2 == 0 ? niz[i] : 0;
            }
            Console.WriteLine($"zbir parnih brojeva niza iznosi: {zbir}");
        }
        static void Zad14()
        {
            int[] niz = new int[10];
            Random rand = new Random();
            Console.WriteLine("Svaki treci broj niza:");
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rand.Next(100);
                Console.WriteLine(niz[i]);
            }
        }
        static void Zad15(int[] a)
        {
            Console.WriteLine($"prvi clan niza je: {a[0]}, poslednji clan niza je: {a[a.Length - 1]}");
        }
        static void Zad16()
        {
            int[] x = new int[20];
            Random rand = new Random();
            int a = 0, brojac = 0, zbir = 0;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rand.Next(50);
                if (x[i] < 15 || x[i] > 35)
                {
                    a++;
                }
            }
            int[] y = new int[a];
            Console.WriteLine("brojevi koji su manji od 15 a vezi od 35:");
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 15 || x[i] > 35)
                {
                    y[brojac] = x[i];
                    Console.WriteLine(y[brojac]);
                    brojac++;
                }
            }
            foreach (int item in y)
            {
                zbir += item;
            }
            Console.WriteLine($"srednja vrednost brojeva koji su veci od 35 a manji od 15: {(decimal)zbir / y.Length}");
        }
        static void Zad17(int a)
        {
            int[] niz = new int[a];
            Random rand = new Random();
            int zbirNiza = 0, brojac = 0;
            Console.WriteLine("Niz:");
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rand.Next(20);
                zbirNiza += niz[i];
                Console.WriteLine(niz[i]);
                brojac += i;
            }
            Console.WriteLine($"Zbir niza iznosi: {zbirNiza}, duzina niza je {a}, srednja vrednost indeksa niza iznosi {(decimal)brojac / a}");
        }
        static void Zad18()
        {
            int[] niz = new int[20], nizJedan = new int[11];
            Random rand = new Random();
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = rand.Next(1, 11);
                nizJedan[niz[i]]++;
            }
            for (int i = 1; i < nizJedan.Length; i++)
            {
                Console.WriteLine($"broj {i} se ponovio {nizJedan[i]} puta");
            }
        }


    }
}
