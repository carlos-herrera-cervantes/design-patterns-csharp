using System;

public class Principal
{
    static void Main(string[] args)
    {
        Expresion expresionConsulta = null;
        Console.WriteLine("Escriba su consulta: ");
        string consulta = Console.ReadLine();
        try
        {
            expresionConsulta = Expresion.Analiza(consulta);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            expresionConsulta = null;
        }
        if (expresionContula != null)
        {
            Console.WriteLine("Escriba la descripción de un vehículo: ");
            string descripcion = Console.ReadLine();
            if (expresionConsulta.Evalua(descripcion))
            {
                Console.WriteLine("La descripción responde a la consulta");
            }
            else
            {
                Console.WriteLine("La descripción no responde a la consulta");
            }
        }
    }
}