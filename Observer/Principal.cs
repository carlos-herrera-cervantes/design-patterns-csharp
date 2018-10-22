using System;

public class Principal
{
    static void Main(string[] args)
    {
        Vehiculo vehiculo = new Vehiculo();
        vehiculo.GetSetDescripcion = "Vehículo económico";
        vehiculo.GetSetPrecio = 5000.0;
        VistaVehiculo vistaVehiculo = new VistaVehiculo(vehiculo);
        vistaVehiculo.Redibuja();
        vehiculo.GetSetPrecio = 4500.0;
        VstaVehiculo vistaVehiculo2 = new VistaVehiculo(vehiculo);
        vehiculo.GetSetPrecio = 5500.0;
    }
}