public abstract class Decorador : IComponenteGraficoVehiculo
{
    #region snippet_Properties
    protected IComponenteGraficoVehiculo Componente;
    #endregion
    
    #region snippet_Constructor
    public Decorador(IComponenteGraficoVehiculo componente)
    {
        Componente = componente;
    }
    #endregion
    
    #region snippet_Methods
    public virtual void Visualiza()
    {
        Componente.Visualiza();
    }
    #endregion
}