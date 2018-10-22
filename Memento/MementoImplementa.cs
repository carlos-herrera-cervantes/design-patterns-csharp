using System;
using System.Collections.Generic;

public class MementoImplementa : IMemento
{
    #region snippet_Properties
    protected IList<OpcionVehiculo> Opciones = new List<OpcionVehiculo>();
    protected IList<OpcionVeiculo> Estado
    {
        get
        {
            return Opciones;
        }
        set
        {
            this.Opciones.Clear();
            foreach (OpcionVehiculo opcion in value)
            {
                this.Opciones.Add(opcion);
            }
        }
    }
    #endregion
}