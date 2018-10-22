using System;
using System.Collections.Generic;

public class ComponenteCatalogo : ICatalogo
{
    #region snippet_Properties
    protected object[] DescripcionVehiculo = {
        "Berlina 5 puertas", 6000, "Compacto 3 puertas", 4000,
        "Espace 5 puertas", 8000, "Break 5 puertas", 7000,
        "Coupé 2 puertas", 9000, "Utilitario 3 puertas", 5000
    };
    #endregion
    
    #region snippet_Methods
    public IList<string> BuscaVehiculo(int precioMin, int precioMax)
    {
        int indice;
        int tamano;
        IList<string> resultado = new List<string>();
        tamano = DescripcionVehiculo.Length / 2;
        for (indice = 0; indice < tamano; indice++)
        {
            int precio = (int)DescripcionVehiculo[2 * indice + 1];
            if ((precio >= precioMin) && (precio <= precioMax))
            {
                resultado.Add((string)DescripcionVehiculo[2 * indice]);
            }
        }
        return resultado;
    }
    #endregion
}