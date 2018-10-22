using System;

public class FormularioAppletImplementacion : IFormularioImplementacion
{
    public void DibujaTexto(string texto)
    {
        Console.WriteLine("Applet: " + texto);
    }
    
    public string AdministraZonaIndicada()
    {
        return Console.ReadLine();
    }
}