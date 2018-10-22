using System;

public class Principal
{
    static void Main(string[] args)
    {
        FabricaOpcion fabrica = new FabricaOpcion();
        VehiculoSolicitado vehiculo = new VehiculoSolicitado();
        vehiculo.AgregaOpciones("air bag", 80, fabrica);
        vehiculo.AgregaOpciones("dirección asisitida", 90, fabrica);
        vehiculo.AgregaOpciones("elevalunas eléctrico", 85, fabrica);
        vehiculo.MuestraOpciones();
    }
}