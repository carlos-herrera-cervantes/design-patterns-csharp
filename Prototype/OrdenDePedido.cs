using System;

public class OrdenDePedido : Documento
{
    #region Métodos
    public override void Visualiza()
    {
        Console.WriteLine("Muestra la orden de pedido: " + contenido);
    }

    public override void Imprime()
    {
        Console.WriteLine("Imprime la orden de pedido: " + contenido);
    }
    #endregion
}