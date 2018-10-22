using System;

public class ModeloDecorador : Decorador
{
    #region snippet_Constructor
    public ModeloDecorador(IComponenteGraficoVehiculo componente) : base(Componente)
    { }
    #endregion
    
    #region snippet_Methods
    protected void VisualizaInformacionTecnica()
    {
        Console.WriteLine("Información técnica del modelo");
    }
    
    public override void Visualiza()
    {
        base.Visualiza();
        this.VisualizaInformacionTecnica();
    }
    #endregion
}