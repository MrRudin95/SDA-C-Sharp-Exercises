﻿

/*

Napisz metodę, która będzie wyświetlała prosty cennik danego produktu.
W zależności od ceny produktu oraz liczby linii, którą ktoś sobie życzy widzieć wydrukuj cennik w
postaci:
Liczba sztuk: 1 łączna cena: 5zł
Liczba sztuk: 2 łączna cena: 10zł
Liczba sztuk: 3 łączna cena: 15zł
*/

using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;
            int price;

            quantity = 3;
            price = 5;

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Liczba sztuk: " + i + " łączna cena: " + i * price + "zł");
            }
        }
    }
}
