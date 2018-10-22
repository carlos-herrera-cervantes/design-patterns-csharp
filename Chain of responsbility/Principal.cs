using System;

public class Principal
{
    static void Main(string[] args)
    {
        ObjetoBasico vehiculo1 = new Vehiculo("Auto deportivo CamaroZ1");
        Console.WriteLine(vehiculo1.DevuelveDescripcion());
        ObjetoBasico modelo1 = new Modelo("2018", "Vehículo amplio y comfortable");
        ObjetoBasico vehiculo2 = new Vehiculo(null);
        vehiculo2.Siguiente = modelo1;
        Console.WriteLine(vehiculo2.DevuelveDescripcion());
        ObjetoBasico marca1 = new Marca("Chevrolet", "Marca del automovil", "de gran calidad");
        ObjetoBasico modelo2 = new Modelo("2012", null);
        modelo2.Siguiente = marca1;
        ObjetoBasico vehiculo3 = new Vehiculo(null);
        vehiculo3.Siguiente = modelo2;
        Console.WriteLine(vehiculo3.DevuelveDescripcion());
        ObjetoBasico vehiculo4 = new Vehiculo(null);
        Console.WriteLine(vehiculo4.DevuelveDescripcion());
    }
}