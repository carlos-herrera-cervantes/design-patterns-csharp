public class CatalogoVehiculo : Catalogo<Vehiculo, ITeradorVehiculo>
{
    public CatalogoVehiculo()
    {
        Contenido.Add(new Vehiculo("VEhículo económico"));
        Contenido.Add(new Vehiculo("Pequeño vehículo económico"));
        Contenido.Add(new Vehiculo("Vehículo de gran calidad"));
    }
}