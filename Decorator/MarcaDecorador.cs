using System;

public class MarcaDecorador : Decorador
{
    #region snippet_Constructor
    public MarcaDecorador(IComponenteGRaficoVehiculo componente) : base(Componente) {}
    #endregion
    
    #region snippet_Methods
    protected void VisualizaLogo()
    {
        Console.WriteLine("Logotipo de la marca");
    }
    
    public override void Visualiza()
    {
        base.Visualiza();
        this.VisualizaLogo();
    }
    #endregion
}