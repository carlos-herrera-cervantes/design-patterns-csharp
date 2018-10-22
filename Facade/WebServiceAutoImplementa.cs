using System;
using System.Collections.Generic;

public class WebServiceAutoImplementa : WebServiceAuto
{
    #region snippet_Instances
    protected ICatalogo catalogo = new ComponenteCatalogo();
    protected IGestionDocumento gestionDocumento = new ComponenteGestionDocumento();
    #endregion
    
    #region snippet_Methods
    public string Documento(int indice)
    {
        return gestionDocumento.Documento(indice);
    }
    
    public IList<string> BuscaVehiculos(int precioMedio, int desviacionMax)
    {
        return catalogo.BuscaVehiculos(precioMedio - desviacionMax, precioMedio + desviacionMax);
    }
    #endregion
}