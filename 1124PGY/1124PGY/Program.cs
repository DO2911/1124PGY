using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1124PGY
{
    struct Titanic
    {
        public string Nev;
        public int Tulelo;
        public int Eltunt;

        public Titanic(string nev, int tulelo, int eltunt)
        {
            Nev = nev;
            Tulelo = tulelo;
            Eltunt = eltunt;
        }
    }
    
    class Program
    {
        static Titanic[] titan = new Titanic[11];
        static void Main(string[] args)
        {
            Beolvasas();
            F02();
            F03();
            F045();
            F06();
            F07();

            Console.ReadKey(true);
        }

        private static void F07()
        {
            int maxi = 0;
            for (int i = 1; i < titan.Length; i++)
            {
                if (titan[i].Tulelo>titan[maxi].Tulelo)
                {
                    maxi = i;
                }
            }
            Console.WriteLine("7. feladat: {0}",titan[maxi].Nev);
        }

        private static void F06()
        {
            Console.WriteLine("6. feladat:");
            foreach (var c in titan)
            {
                if ((c.Eltunt+c.Tulelo)*0.6<c.Eltunt)
                {
                    Console.WriteLine($"\t{c.Nev}");
                }
            }
        }

        private static void F045()
        {
            bool van = false;
            Console.Write("4. feladat: Kulcsszó: ");
            string kulcs = Console.ReadLine();
            foreach (var c in titan)
            {
                if (c.Nev.Contains(kulcs))
                {
                    van = true;
                }
            }
            if (van)
            {
                Console.WriteLine("\tVan benne");
            }
            else
            {
                Console.WriteLine("\tNincs benne");
            }
            Console.WriteLine("5. feladat:");
            if (van)
            {
                foreach (var c in titan)
                {
                    if (c.Nev.Contains(kulcs))
                    {
                        Console.WriteLine($"\t{c.Nev} {c.Tulelo}");
                    }
                }
            }
            else Console.WriteLine("\tNincs benne");
            
        }

        private static void F03()
        {
            int sum = 0;
            foreach (var c in titan)
            {
                sum += c.Tulelo + c.Eltunt;
            }
            Console.WriteLine($"3. feladat:{sum} fő");
        }

        private static void F02()
        {
            Console.WriteLine($"2. feladat:{titan.Length} db");
        }

        private static void Beolvasas()
        {
            
            StreamReader sr = new StreamReader(@"..\..\Res\titanic.txt");
            for (int i = 0; i < titan.Length; i++)
            {
                string[] sor = sr.ReadLine().Split(';');
                titan[i] = new Titanic(sor[0], int.Parse(sor[1]), int.Parse(sor[2]));
            }
            sr.Close();
        }
    }
}
