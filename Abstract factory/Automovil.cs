using System;

public abstract class Automovil
{
    protected string Modelo;
    protected string Color;
    protected int Potencia;
    protected double Espacio;
    
    public Automovil(string modelo, string color, int potencia, double espacio)
    {
        Modelo = modelo;
        Color = color;
        Potencia = potencia;
        Espacio = espacio;
    }
    
    public abstract void MostrarCaracteristicas();
}