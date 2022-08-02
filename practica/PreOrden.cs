using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class PreOrden: OrdenBase
    {
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("Calculo del precio total en una preorden ");
                return productos.Sum(x => x.Precio)* 0.9;
        }
}
}
