using System;
namespace practica
{
    internal class Program
{
    private static void Main(string[] args)
    {
        var OrdenRegular= new OrdenRegular();
        Console.WriteLine(OrdenRegular.CalculoTotalPrecio());
        Console.WriteLine();

        var preOrder=new PreOrden();
        Console.WriteLine(preOrder.CalculoTotalPrecio());
        Console.WriteLine();
        var ordenPremium = new OrdenPremium(preOrder);
        Console.WriteLine(ordenPremium.CalculoTotalPrecio());
        Console.WriteLine();
    }
}
}