using System;

public class Producto
{
    #region snippet_Properties
    protected string Nombre;
    #endregion
        
    #region snippet_Constructor
    public Producto(string nombre)
    {
        Nombre = nombre;
    }
    #endregion
        
    #region snippet_Methods
    public void Visualiza()
    {
        Console.WriteLine("Producto: " + Nombre);
    }
    #endregion
}