using System;

public class VistaVehiculo
{
    #region snippet_Properties
    protected string Descripcion;
    #endregion
        
    #region snippet_Constructor
    public VistaVehiculo(string descripcion)
    {
        Descripcion = descripcion;
    }
    #endregion
        
    #region snippet_Methods
    public void Dibuja()
    {
        Console.Write(descripcion);
    }
    #endregion
}