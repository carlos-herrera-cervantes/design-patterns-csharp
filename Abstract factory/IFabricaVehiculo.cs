using System;

public interface IFabricaVehiculo
{
    Automovil CreaAutomovil(string modelo, string color, int potencia, double espacio);
    
}