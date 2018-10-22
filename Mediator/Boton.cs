using System;

public class Boton : Control
{
    #region snippet_Constructor
    public Boton(string nombre) : base(nombre) { }
    #endregion
    
    #region snippet_Methods
    public override void Informa()
    {
        Console.WriteLine("¿Desea activar el botón " + Nombre + " ?");
        string respuesta = Console.ReadLine();
        if (respues == "sí")
        {
            this.Modifica();
        }
    }
    #endregion
}