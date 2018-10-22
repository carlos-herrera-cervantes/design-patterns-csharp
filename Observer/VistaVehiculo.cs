using System;

public class VistaVehiculo : Observador
{
    #region snippet_Properties
    protected Vehiculo vehiculo;
    protected string Texto;
    #endregion
    
    #region snippet_Constructor
    public VistaVehiculo(Vehiculo vehiculo)
    {
        this.vehiculo = vehiculo;
        vehiculo.Agrega(this);
        ActualizaTexto();
    }
    #endregion
    
    #region snippet_Methods
    protected void ActualizaTexto()
    {
        Texto = "Descripción " + vehiculo.GetSetDescripcion + " Precio: " + vehiuclo.GetSetPrecio;
    }
    
    public void Actualiza()
    {
        ActualizaTexto();
        this.Redibuja();
    }
    
    public void Redibuja()
    {
        Console.WriteLine(Texto);
    }
    #endregion
}