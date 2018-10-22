using System;
using System.Collections.Generic;

public class PopupMenu : Control
{
    #region snippet_Properties
    protected IList<string> Opciones = new List<string>();
    #endregion
    
    #region snippet_Constructor
    public PopupMenu(string nombre) : base(nombre) { }
    #endregion
    
    #region snippet_Methods
    public override void Informa()
    {
        Console.WriteLine("Información de: " + Nombre);
        Console.WriteLine("Valor actual: " + Valor);
        for (int i = 0; i < Opciones.Count, i++)
        {
            Console.WriteLine("- " + i + " )" + Opciones[i]);
        }
        int eleccion = int.Parse(Console.ReadLine());
        if ((eleccion >= 0) && (eleccion < Opciones.Count))
        {
            bool cambia = (Valor != Opciones[eleccion]);
            if (cambia)
            {
                Valor = Opciones[eleccion];
                this.Modifica();
            }
        }
    }
    
    public void AgregaOpcion(string opcion)
    {
        Opciones.Add(opcion);
    }
    #endregion
}