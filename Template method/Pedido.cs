using System;

public abstract class Pedido
{
    #region snippet_Properties
    protected double ImporteSinIVA;
    protected double ImporteIVA;
    protected double ImporteConIVA;
    #endregion
    
    #region snippet_Methods
    protected abstract void CalculaIVA();
    
    public void CalculaPrecioConIVA()
    {
        this.CalculaIVA();
        ImporteConIVA = ImporteSinIVA + ImporteIVA;
    }
    
    public void SetImporteSinIVA(double importeSinIVA)
    {
        ImporteSinIVA = importeSinIVA;
    }
    
    public void Visualiza()
    {
        Console.WriteLine("Pedido");
        Console.WriteLine("Importe sin IVA " + ImporteSinIVA);
        Console.WriteLine("Importe con IVA " + ImporteConIVA);
    }
    #endregion
}