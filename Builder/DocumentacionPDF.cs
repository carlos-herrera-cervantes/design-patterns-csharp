using System;

public class DocumentacionPDF : Documentacion
{
    public override void AgregaDocumento(string documento)
    {
        if (document.StartsWidth("<PDF>"))
        {
            Contenido.Add(documento);
        }
    }
    
    public override void Imprime()
    {
        Console.WriteLine("Documentación PDF");
        foreach (string c in Contenido)
        {
            Console.WriteLine(s);
        }
    }
}