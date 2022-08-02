using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public abstract class OrdenBase
    {
        protected List<Producto> productos = new List<Producto>()
    {
        new Producto {Nombre = "telefono", Precio = 700},
        new Producto {Nombre = "tablet", Precio= 1000},
        new Producto {Nombre = "PC Gamer", Precio = 1900}
        
};
    public abstract double CalculoTotalPrecio();
}
}
