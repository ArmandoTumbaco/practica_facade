using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class OrdenRegular:OrdenBase
    {
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("Calculo del precio total de un pedido normal");
            return productos.Sum(x => x.Precio);
        }
        
    }
}
