//using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Xml.Serialization;

namespace CarManagment 
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Console.Clear();
                Console.WriteLine("_________________________________");
                Console.WriteLine("|   C A R   M A N A G M E N T   |");
                Console.WriteLine("|_______________________________|");
                Console.WriteLine("|     Proszę wybrać cyfrę:      |");
                Console.WriteLine("|   1 - Raport o stanie floty   |");
                Console.WriteLine("|   2 - Raport o samochodzie    |");
                Console.WriteLine("|   3 - Dodać nowy pojazd       |");
                Console.WriteLine("|   4 - Usunąć pojazd           |");
                Console.WriteLine("|                               |");
                Console.WriteLine("|   0 - Zakończ program         |");
                Console.WriteLine("|_______________________________|");

                int choice = 0;
                string menu = Console.ReadLine();
                if (Int32.TryParse(menu, out choice))
                {
                    if (choice == 0) break;
                    switch (choice)
                    {
                        case 1: Console.WriteLine("wybrałeś 1 "); break;
                        case 2: Console.WriteLine("Wybrałeś 2 "); break;
                        case 3: Console.WriteLine("wybrałeś 3 "); break;
                        case 4: Console.WriteLine("wybrałeś 4 "); break;
                        default: Console.WriteLine("Brak opcji: " + choice); break;

                    }
                }
                else  Console.WriteLine(menu + " <- to nie jest liczba!");
                Console.ReadKey();
                
            }
           
        }

    }




}

