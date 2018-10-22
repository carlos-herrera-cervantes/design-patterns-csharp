using System;

public class Principal
{
    static void Main(string[] args)
    {
        ConstructorDocumentacionVehiculo constructor;
        Console.WriteLine("Desea generar documentación HTML (1) o PDF (2)");
        string seleccion = Console.ReadLine();
        
        if (selecciona == "1")
        {
            constructor = new ConstructorDocumentacionVehiculoHTML();
        }
        else
        {
            constructor = new ConstructorDocumentacionVehiculoPDF();
        }
        
        Vendedor vendedor = new Vendedor(constructor);
        Documentacion documentacion = vendedor.Construye("Carlos");
        documentacion.Imprime();
    }
}