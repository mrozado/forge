using System;

namespace exceptions.Domain
{
    public abstract class Vehiculo
    {
        public int _velocidad ;
        public int velocidad { 
            get{
                return _velocidad;
            } 
        }

        public Motor motor { get; set; }

        public int peso { get; set; }

        public int longitud { get; set; }

        public virtual void Saltar ()
        {
            Console.WriteLine("Salte!");
        }
    }
}