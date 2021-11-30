using System;

namespace EjerciciodePuerta
{
    class Program
    {
        static void Main(string[] args)
        {
            Puerta puerta = new Puerta();

            Console.WriteLine(puerta.Close());

            Console.ReadKey();
        }
    }
}
