using System;

public abstract class FormularioMatriculacion
{
    #region snippet_Properties
    protected string Contenido;
    protected IFormularioImplementacion Implementacion;
    #endregion
        
    #region snippet_Constructor
    public FormularioMatriculacion(IFormularioImplementacion implementacion)
    {
        Implementacion = implementacion;
    }
    #endregion
        
    #region snippet_Methods
    public void Visualiza()
    {
        Implementacion.DibujaTexto("Número de matrícula existente: ");
    }
    
    public void GeneraDocumento()
    {
        Implementacion.DibujaTexto("Solicitud de matriculación");
        Implementacion.DibujaTexto("Número de matrícula: " + Contenido);
    }
    
    public bool AdministraZona()
    {
        Contenido = Implementacion.AdministraZonaIndicada();
        return this.ControlZona(Contenido);
    }
    
    protected abstract bool ControlZona(string matricula);
    #endregion
}