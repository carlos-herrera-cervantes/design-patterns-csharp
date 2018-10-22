using System;
using System.Collections.Generic;

public class Principal
{
    static void Mian(string[] args)
    {
        IWebServiceAuto webServiceAuto = new WebServiceAutoImplementa();
        Console.WriteLine(webServiceAuto.Documento(0));
        Console.WriteLine(webServiceAuto.Documento(1));
        IList<string> resultados = webServiceAuto.BuscaVehiculos(6000, 1000);
        if (resultados.Count > 0)
        {
            Console.WriteLine("Vehiculo(s) cuyo precio está comprendido entre 5000 y 7000");
            foreach (string resultado in resultados)
            {
                Console.WriteLine(" " + resultado);
            }
        }
    }
}