//Utilizar las clases del patrón Prototype
//Este es una clase que complementa al patrón Prototype para demostrar el patrón Singleton
using System;

public class Comercial
{
    #region Propiedades
    public string Nombre { get; set; }
    public string Direccion { get; set }
    public string Email { get; set; }

    private static Comercial _instance = null;
    #endregion

    #region Constructor
    public Comercial() {}
    #endregion

    #region Métodos
    public static Comercial Instance()
    {
        if (_instance == null)
        {
            _instance = new Comercial();
        }
        return _instance;
    }

    public void Visualiza()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Email: " + Email);
    }
    #endregion
}