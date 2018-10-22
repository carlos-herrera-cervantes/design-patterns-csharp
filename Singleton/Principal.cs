using System;

public class Principal
{
    #region Método principal
    static void Main(string[] args)
    {
        Comercial comercial = Comercial.Instance();
        comercial.Nombre = "Chevrolet";
        comercial.Direccion = "México";
        comercial.Email = "empresa@chevrolet.com";

        Visualiza();
    }
    #endregion

    #region Métodos
    public static void Visualiza()
    {
        Comercial comercial = Comercial.Instance();
        comercial.Visualiza();
    }
    #endregion
}