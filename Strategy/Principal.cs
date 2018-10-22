using System;

public class Principal
{
    static void Main(string[] args)
    {
        VistaCatalogo vistaCatalogo1 = new VistaCatalogo(new DibujaTresVehiculosPorLinea());
        vistaCatalogo1.Dibuja();
        VistaCatalogo vistaCatalogo2 = new VistaCatalogo(new DibujaVehiculoPorLinea());
        vistaCatalogo2.Dibuja();
    }
}