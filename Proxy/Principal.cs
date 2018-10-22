using System;

public class Principal
{
    static void Main(string[] args)
    {
        IAnimacion animacion = new AnimacionProxy();
        animacion.Dibuja();
        animacion.Clic();
        animacion.Dibuja();
    }
}