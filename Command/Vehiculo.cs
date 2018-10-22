using System;

public class Vehiculo
{
    #region snippet_Properties
    protected string Nombre;
    protected long FechaEntradaStock;
    protected double PrecioVenta
    #endregion
        
    #region snippet_Constructor
    public Vehiculo(string nombre, long fechaEntradaStock, double precioVenta)
    {
        Nombre = nombre;
        FechaEntradaStock = fechaEntradaStock;
        PrecioVenta = precioVenta;
    }
    #endregion
        
    #region snippet_Methods
    public long GetTiempoEnStock(long hoy)
    {
        return hoy - FechaEntradaStock;
    }
    
    public void ModificaPrecio(double coeficiente)
    {
        PrecioVenta = 0.01 * Math.Round(coeficiente * PrecioVenta * 100);
    }
    
    public void Visualiza()
    {
        Console.WriteLine(nombre + " precio: " + PrecioVenta + " fecha de entrada stock " + FechaEntradaStock);
    }
    #endregion
}