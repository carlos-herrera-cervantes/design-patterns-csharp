using System;

public abstract class Empresa
{
    #region snippet_Properties
    public string Nombre { get; protected set; }
    public string Email { get; protected set; }
    public string Direccion { get; protected set; }
    #endregion
        
    #region snippet_Constructor
    public Empresa(string nombre, string email, string direccion)
    {
        Nombre = nombre;
        Email = email;
        Direccion = direccion;
    }
    #endregion
        
    #region snippet_Methods
    public abstract bool AgregaFilial(Empresa filial);
    
    public abstract void AceptaVisitante(Visitante visitante);
    #endregion
}