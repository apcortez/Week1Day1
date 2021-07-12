using System;

namespace Week1Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //serve per stampare a video Hello World
            /* questo è
             * un commento
             * su più righe */
            int a; //dichiarazione
            a = 1; //assegnazione
            //int a = 1;   //inizializzazione
            int b = 2;
            b = 5;

            const int N = 50;
            //N = 40;  //non può essere modificato il valore di una costante

            int var1 = 2, var2 = 2, var3 = 3; //inizializzazione di più variabili su un unica riga

            string parola = "ciao a tutte!";
            char carattere = 'a';

            string s = "20";
            int ss = 20;

            byte c; //tra 0 e 255, 8 bit
            short d; //16 bit
            int i; //32 bit
            long l; //64 bit

            float f = 2.33f;
            double pi = 3.12391313;
            decimal dec = 123.452m;

            bool isSunny = true;
            bool isRed;

            Console.WriteLine(parola);
            Console.WriteLine(carattere);

            int x = 1;
            int y = 2;
            Console.WriteLine($"Ciao, il valore della prima variabile è {x}. Il valore della seconda variabile è {y}");
            Console.WriteLine("Ciao, il valore della prima variabile è {0}. Il valore della seconda variabile è {1}");
            Console.WriteLine($"{x}\t{y}");

            Console.WriteLine("Come ti chiami?");
            string nome = Console.ReadLine();
            Console.WriteLine($"Il tuo nome è {nome}");
        }
    }
}
