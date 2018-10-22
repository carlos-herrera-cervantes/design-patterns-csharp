using System;

public class DocumentacionHTML : Documentacion
{
    public override void AgregaDocumento(string documento)
    {
        if (document.StartsWidth("<HTML>"))
        {
            Contenido.Add(documento);
        }
    }
    
    public override void Imprime()
    {
        Console.WriteLine("Documentación HTML");
        foreach (string c in Contenido)
        {
            Console.WriteLine(s);
        }
    }
}