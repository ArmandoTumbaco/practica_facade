using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class Decorador: OrdenBase
    {
        protected OrdenBase orden;
        public Decorador (OrdenBase orden)
        {
            this.orden = orden;
        }
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("Calculo del precio total desde la clase decorador");
            return orden.CalculoTotalPrecio();  
        }
    }
}
