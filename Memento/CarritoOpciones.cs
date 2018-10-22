using System;
using System.Collections.Generic;

public class CarritoOpciones
{
    #region snippet_Properties
    protected IList<OpcionVehiculo> Opciones = new List<OpcionVehiculo>();
    #endregion
        
    #region snippet_Methods
    public IMemento AgregaOpcion(OpcionVehiculo opcionVehiculo)
    {
        MementoImplementa resultado = new MementoImplementa();
        resultado.Estado = Opciones;
        IList<OpcionVehiculo> opcionesIncompatibles = opcionVehiculo.OpcionesIncompatibles;
        foreach (OpcionVehiculo opcion in opcionesIncompatibles)
        {
            Opciones.Remove(opcion);
        }
        Opciones.Add(opcionVehiculo);
        return resultado;
    }
    
    public void Anula(IMemento memento)
    {
        MementoImplementa mementoImplementaInstance = memento as MementoImplementa;
        if (mementoImplementaInstance == null)
        {
            return;
        }
        Opciones = mementoImplementaInstance.Estado;
    }
    
    public void Visualiza()
    {
        Console.WriteLine("Contenido del carrito de opciones");
        foreach (OpcionVehiculo opcion in Opciones)
        {
            opcion.Visualiza();
        }
        Console.WriteLine();
    }
    #endregion
}