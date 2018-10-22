using System;
using System.Collections.Generic;

public interface IWebServiceAuto
{
    string Documento(int indice);
    IList<string> BuscaVehiculos(int precioMedio, int desviacionMax);
}