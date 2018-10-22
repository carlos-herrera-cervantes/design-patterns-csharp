using System;
using System.Collections.Generic;

public class DibujaVehiculoPorLinea : IDibujaCatalogo
{
    public void Dibuja(IList<VistaVehiculo> contenido)
    {
        Console.WriteLine("Dibuja los vehículos mostrando un vehículo por línea");
        foreach (VistaVehiculo vistaVehiculo in contenido)
        {
            vistaVehiculo.Dibuja();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}