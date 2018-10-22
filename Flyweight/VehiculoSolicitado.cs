using System;
using System.Collections.Generic;

public class VehiculoSolicitado
{
    #region snippet_Instances
    protected IList<OpcionVehiculo> opciones = new List<OpcionVehiculo>();
    protected IList<int> precioDeVentaOpciones = new List<int>();
    #endregion
        
    #region snippet_Methods
    public void AgregaOpciones(string nombre, int precioDeVenta, FrabicaOpcion fabrica)
    {
        opciones.Add(fabrica.GetOpcion(nombre));
        precioDeVentaOpciones.Add(precioDeVenta);
    }
    
    public void MuestraOpciones()
    {
        int indice;
        int tamano = opciones.Count;
        for (indice = 0; indice < tamano; indice++)
        {
            opciones[indice].Visualiza(precioDeVentaOpciones[indice]);
            Console.WriteLine();
        }
    }
    #endregion
}