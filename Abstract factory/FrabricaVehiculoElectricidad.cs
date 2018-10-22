using System;

public class FabricaVehiculoElectricidad : IFabricaVehiculo
{
    public Automovil CreaAutomovil(string modelo, string color, int potencia, double espacio)
    {
        return new AutomovilElectricidad(modelo, color, potencia, espacio);
    }
}