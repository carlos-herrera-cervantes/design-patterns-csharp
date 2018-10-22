using System;

public interface IDocumento
{
    #region Propiedades
    string Contenido { set;}
    #endregion
    
    #region Métodos
    void Dibuja();
    void Imprime();
    #endregion
}