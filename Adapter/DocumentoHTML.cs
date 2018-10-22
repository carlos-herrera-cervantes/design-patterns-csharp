using System;

public class DocumentoHTML : IDocumento
{
    #region Propiedades
    protected string _Contenido;
    protected string Contenido
    {
        protected get
        {
            return _Contenido;
        }
        set
        {
            _Contenido = value;
        }
    }
    #endregion
    
    #region Métodos
    public void Dibuja()
    {
        Console.WriteLine("Dibuja el documento HTML: " + contenido);
    }
    
    public void Imprime()
    {
        Console.WriteLine("Imprime el documento HTML: " + contenido);
    }
    #endregion
}