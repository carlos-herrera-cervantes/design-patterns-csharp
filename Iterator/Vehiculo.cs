using System;

public class Vehiculo : Elemento
{
    #region snippet_Constructor
    public Vehiculo(string descripcion) : base(descripcion) { }
    #endregion
    
    #region snippet_Methods
    public void Visualiza()
    {
        Console.WriteLine("Descripción del vehículo: " + descripcion);
    }
    #endregion
}