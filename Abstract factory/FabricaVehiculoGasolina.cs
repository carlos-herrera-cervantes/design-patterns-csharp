using System;

public class FabricaVehiculoGasolina : IFabricaVehiculo
{
    public Automovil CreaAutomovil(string modelo, string color, int potencia, double espacio)
    {
        return new AutomovilGasolina(modelo, color, potencia, espacio);
    }
}