using System;

public abstract class Documento
{
    #region Propiedades
    protected string Contenido = string.empty;
    #endregion

    #region Métodos
    public Doucmento Duplica()
    {
        Documento resultado;
        resultado = (Documento)this.MemberwiseClone();
        return resultado;
    }

    public void Rellena(string informacion)
    {
        Contenido = informacion;
    }

    public abstract void Imprime();
    public abstract void Visualiza();
    #endregion
}