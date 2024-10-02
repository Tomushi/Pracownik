using System;

namespace Pracownik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w systemie dodawania pracownikow");
         
            Console.WriteLine("Podaj imie pracownika");
            
            string imie = Console.ReadLine();
            
            Console.WriteLine("Podaj nazwisko pracownika");
            
            string nazwisko = Console.ReadLine();
            
            Console.WriteLine("Podaj wiek pracownika");
            
            int wiek = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Płeć pracownika");

            string plec = "";
            bool validPlec = false;

            while (!validPlec)
            {
                Console.WriteLine("Podaj płeć pracownika (K/M)");
                plec = Console.ReadLine();
                if (plec == "K" || plec == "M")
                {
                    validPlec = true;
                }
                else
                {
                    Console.WriteLine("Podano nieprawidłową płeć");
                }
            }

            Console.WriteLine("Podaj PESEL pracownika");
            
        }
    }
}
