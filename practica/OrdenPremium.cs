using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class OrdenPremium : Decorador
    {
        public  OrdenPremium(OrdenBase orden) : base(orden)
        {

        }
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("calculo total precio orden premium");
            var precioOrdenPrecio = base.CalculoTotalPrecio();
            return precioOrdenPrecio *0.9;
            
        }
    }
}
