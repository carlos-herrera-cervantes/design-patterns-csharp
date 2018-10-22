using System;

public abstract class Control
{
    #region snippet_Properties
    public string Valor { get; protected set; }
    public Formulario Director { get; set; }
    public string Nombre { get; protected set; }
    #endregion
        
    #region snippet_Constructor
    public Control(string nombre)
    {
        Valor = "";
        Nombre = nombre;
    }
    #endregion
    
    #region snippet_Methods
    public abstract void Informa();
    
    protected void Modifica()
    {
        Director.ControlModificado(this);
    }
    #endregion
}