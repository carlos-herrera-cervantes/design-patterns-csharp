using System;

public abstract class ObjetoBasico
{
    #region snippet_Properties
    public ObjetoBasico Siguiente { protected get; set; }
    protected abstract string Descripcion { get; }
    #endregion
        
    #region snippet_Methods
    private string DescripcionPorDefecto()
    {
        return "descripción por defecto";
    }
    
    public string DevuelveDescripcion()
    {
        string resultado;
        resultado = Descripcion;
        if (resultado != null)
        {
            return resultado;
        }
        if (Siguiente != null)
        {
            return Siguiente.DevuelveDescripcion();
        }
        else
        {
            return this.DescripcionPorDefecto();
        }
    }
    #endregion
}