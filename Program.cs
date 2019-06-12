using System;
using exceptions.Domain;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var auto = new Auto();
            var moto = new Moto();
            Console.WriteLine("Auto:");
            auto.Saltar();
            
            Console.WriteLine("Moto:");
            moto.Saltar();


        }
    }
}
