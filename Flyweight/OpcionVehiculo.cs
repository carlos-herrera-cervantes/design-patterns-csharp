using System;

public class OpcionVehiculo
{
    #region snippet_Properties
    protected string Nombre;
    protected string Descripcion;
    protected int PrecioEstandar;
    #endregion
        
    #region snippet_Constructor
    public OpcionVehiculo(string nombre)
    {
        Nombre = nombre;
        Descripcion = "Descripción de " + nombre;
        PrecioEstandar = 100;
    }
    #endregion
        
    #region snippet_Methods
    public void Visualiza(int precioVenta)
    {
        Console.WriteLine("Opción");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine(Descripcion);
        Console.WriteLine("Precio estándar: " + PrecioEstandar);
        Console.WriteLine("Precio de venta: " + precioVenta);
    }
    #endregion
}