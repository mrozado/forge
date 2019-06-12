using System;

namespace exceptions.Domain
{
    public class Moto : Vehiculo, IVehiculo
    {
        public int cantidadDeRuedas { get; }

        

        public void Acelerar()
        {
            this._velocidad += 5; // kM/h
             Console.WriteLine("Aceleramos la moto en: " + this._velocidad.ToString()) ; 
        }

        public void Acelerar(int aceleracion)
        {
            this._velocidad += aceleracion - 2;
            Console.WriteLine("Aceleramos moto en: " + this._velocidad.ToString()) ; // kM/h
        }

        public void Frenar()
        {
            this._velocidad -= 5; // kM/h
        }
    }
}