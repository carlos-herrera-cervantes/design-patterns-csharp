using System;

public class ComponentePDF
{
    #region Propiedades
    protected string Contenido;
    #endregion
        
    #region Métodos
    public void PDFFijaContenido(string contenido)
    {
        Contendo = contenido;
    }
    
    public void PDFPreparaVisualizacion()
    {
        Console.WriteLine("Visualiza PDF: Comienzo");
    }
    
    public void PDFRefresca()
    {
        Console.WriteLine("Visualiza contenido PDF: " + contenido);
    }
    
    public void PDFFinalizaVisualizacion()
    {
        Console.WriteLine("Visualiza PDF: Fin");
    }
    
    public void PDFEnviaImpresora()
    {
        Console.WriteLine("Impresión PDF: " + contenido);
    }
    #endregion
}