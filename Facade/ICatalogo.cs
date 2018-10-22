using System;
using System.Collections.Generic;

public interface ICatalogo
{
    IList<string> BuscaVehiculos(int precioMin, int precioMax);
}