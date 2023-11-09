using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kartoti = true;
            while (kartoti)
            {
                Console.WriteLine("Jeigu norite įrašyti dešimtainį skaičių, rašykite true, jeigu dvejatainį skaičių, rašykite false: ");
                bool pasirinkimas = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine();

                if (pasirinkimas)
                {
                    Console.WriteLine("Įrašykite dešimtainį skaičių: ");
                    int desimt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    int kiekis = 0;
                    double desimt1 = desimt;
                    double desimt2 = desimt;
                    while (desimt >= 0)
                    {
                        desimt = desimt / 2;
                        kiekis++;
                        if (desimt == 0)
                            break;
                    }
                    int[] ats = new int[kiekis + 1];
                    for (int i = 1; i <= kiekis; i++)
                    {
                        if (desimt1 - Math.Pow(2, kiekis - i) >= 0)
                        {
                            ats[i] = 1;
                            desimt1 = desimt1 - Math.Pow(2, kiekis - i);
                        }
                        else
                        {
                            ats[i] = 0;
                        }
                    }
                    Console.WriteLine("{0} dvejatainis kodas būtų: ", desimt2);
                    for (int i = 1; i <= kiekis; i++)
                    {
                        Console.Write(ats[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Įrašykite dvejatainį skaičių: ");
                    int dvejat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    int kiekis = 0;
                    int dvejat1 = dvejat;
                    while (dvejat >= 0)
                    {
                        dvejat = dvejat / 10;
                        kiekis++;
                        if (dvejat == 0)
                            break;
                    }

                    int[] ats = new int[kiekis + 1];
                    string dvejatS = Convert.ToString(dvejat1);
                    int kiekisi = 1;
                    double sum = 0;
                    foreach (char dvej in dvejatS)
                    {
                        if (dvej == '1')
                            sum += Math.Pow(2, kiekis - kiekisi);
                        kiekisi++;
                    }

                    Console.WriteLine("{0} dešimtainis skaičius būtų: {1}.", dvejat1, sum);
                }
                Console.WriteLine();
                Console.WriteLine("Jei norite įrašyti naują skaičių, rašykite true, jeigu norite baigti, rašykite false: ");
                kartoti = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
