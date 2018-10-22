using System;

public class ZonaInformacion : Control
{
    #region snippet_Constructor
    public ZonaInformacion(string nombre) : base(nombre){ }
    #endregion
    
    #region snippet_Methods
    public override void Informa()
    {
        Console.WriteLine("Información de: " + Nombre);
        Valor = Console.ReadLine();
        this.Modifica();
    }
    #endregion
}