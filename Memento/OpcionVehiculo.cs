using System;
using System.Coleections.Generic;

public class OpcionVehiculo
{
    #region snippet_Properties
    protected string Nombre;
    public IList<OpcionVehiculo> OpcionesIncompatibles { get; protected set; }
    #endregion
        
    #region snippet_Constructor
    public OpcionVehiculo(string nombre)
    {
        OpcionesIncompatibles = new List<OpcionVehiculo>();
        Nombre = nombre;
    }
    #endregion
        
    #region snippet_Methods
    public void AgregaOpcionIncompatible(OpcionVehiculo opcionIncompatible)
    {
        if (!OpcionesIncompatibles.Contains(opcionIncompatible))
        {
            OpcionesIncompatibles.Add(opcionIncompatible);
            opcionIncompatible.AgregaOpcionIncompatible(this);
        }
    }
    
    public void Visualiza()
    {
        Console.WriteLine("opción: " + Nombre);
    }
    #endregion
}