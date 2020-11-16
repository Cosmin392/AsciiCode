using System;

namespace AsciiCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un valore numerico o alfanumerico da convertire");
            char carattere = Convert.ToChar(Console.ReadLine());

            int number = carattere;

            Console.WriteLine(number.ToString());

            Console.ReadKey();


        }
    }
}
