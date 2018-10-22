using System;

public class Pincipal
{
    public static int NoAutos = 3;
    
    static void Main(string[] args)
    {
        IFabricaVehiculo fabrica;
        Automovil[] autos = new Automovil[NoAutos];
        Console.WriteLine("Desea utilizar vehículos eléctricos (1) o de gasolina (2)");
        string seleccion = Console.ReadLine();
        
        if (seleccion == "1")
        {
            fabrica = new FabricaVehiculoElectricidad();
        }
        else
        {
            fabrica = new FabricaVehiculoGasolina();
        }
        
        for (int index = 0; index < NoAutos; index++)
        {
            autos[index] = fabrica.CreaAutomovil("Estándar", "Negro", 6 + index, 3.2);
        }
        
        foreach (Automovil auto in autos)
        {
            auto.MostrarCaracteristicas();
        }
    }
}