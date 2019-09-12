using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Monolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. komputer losuje liczbę z podanego zakresu

            Random los = new Random();
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana); //do usuniecia w Release
#endif
            Console.WriteLine("wylosowałem liczbe z zakresu od 1 do 100. Odgadni ją.");
            Stopwatch czas = Stopwatch.StartNew();

            //powtarzaj wielokrotnie, aż odgadnie
            bool odgadniete = false;
            int licznik = 0;

            do
            {
                licznik++;
                //2. człowiek proponuje (odgaduje)
                Console.Write("podaj swoją propozycję: ");
                string napis = Console.ReadLine();
                if (napis == "koniec")

                {
                    Console.WriteLine("szkoda, że mnie opuzczasz.");
                    return;
                }

                int propozycja = 0;
                try
                {
                    propozycja = int.Parse(napis);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby.\n Spróbuj jeszcze raz");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Przesadziłeś, za duża liczba.");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("niezidentyfikowany wyjątek. Awaria !!");
                    Environment.Exit(1);
                }
                
         
                //3. komputer ocenia propozycję
                //koniec powtarzaj
                if (propozycja < wylosowana)
                {
                    Console.WriteLine("Za mało");
                }
                else if (propozycja > wylosowana)
                {
                    Console.WriteLine("Za dużo");
                }
                else
                {
                    Console.WriteLine("Trafiłeś");
                    //odgadniete = true;
                    break;
                }
            }
            //while (!odgadniete); while(propozycja !=wylosowana5)
            while (true);

            czas.Stop();
            //4. wypisz statystyki gry


            Console.WriteLine($"*liczba ruchow{licznik}");
            Console.WriteLine($"-czas gry:{czas.Elapsed}");
                
            



            
        }
    }
}
