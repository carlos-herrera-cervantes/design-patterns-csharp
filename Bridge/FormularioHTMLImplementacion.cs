using System;

public class FormularioHTMLImplementacion : IFormularioImplementacion
{
    public void DibujaTexto(string texto)
    {
        Console.WriteLine("HTML: " + texto);
    }
    
    public string AdministraZonaIndicada()
    {
        return Console.ReadLine();
    }
}