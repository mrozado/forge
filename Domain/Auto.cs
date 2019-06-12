using System;
using System.Collections;

namespace exceptions.Domain
{
    public class Auto : Vehiculo, IVehiculo
    {
        public int cantidadDeRuedas { get; }

        public override void Saltar()
        {
            base.Saltar();
            Console.WriteLine("Salte distinto");
        }

        public void Acelerar()
        {
            this._velocidad += 10; // kM/h
             Console.WriteLine("Aceleramos en: " + this._velocidad.ToString()) ; 
        }

        public void Acelerar(int aceleracion)
        {
            this._velocidad += aceleracion;
            Console.WriteLine("Aceleramos en: " + this._velocidad.ToString()) ; // kM/h
        }

        public void Frenar()
        {
            this._velocidad -= 10; // kM/h
        }
    }
}