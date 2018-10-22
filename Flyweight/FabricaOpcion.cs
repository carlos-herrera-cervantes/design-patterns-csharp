using System;
using System.Collections.Generic;

public class FabricaOpcion
{
    #region snippet_Instances
    protected IDictionary<string, OpcionVehiculo> opciones = new Dictionary<string, OpcionVehiculo>();
    #endregion
        
    #region snippet_Methods
    public OpcionVehiculo GetOption(string nombre)
    {
        OpcionVehiculo resultado;
        if (opciones.ContainsKey(nombre))
        {
            resultado = opciones[nomnbre];
        }
        else
        {
            resultado = new OpcionVehiculo(nombre);
            opciones.Add(nombre, resultado);
        }
        return resultado;
    }
    #endregion
}