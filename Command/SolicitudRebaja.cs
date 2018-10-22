using System.Collections.Generic;

public class SolicitudRebaja
{
    #region snippet_Properties
    protected IList<Vehiculo> VehiculosEnStock = new List<Vehiculo>();
    protected long Hoy;
    protected long TiempoEnStock;
    protected double TasaDescuento;
    #endregion
        
    #region snippet_Constructor
    public SolicitudRebaja(long hoy, long tiempoEnStock, double tasaDescuento)
    {
        Hoy = hoy;
        TiempoEnStock = tiempoEnStock;
        TasaDescuento = tasaDesciento;
    }
    #endregion
        
    #region snippet_Methods
    public void Rebaja(IList<Vehiculo> vehiculos)
    {
        VehiculosEnStock.Clear();
        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (vehiculo.GetTiempoEnSotck(Hoy) >= TiempoEnStock)
            {
                VehiculosEnStock.Add(vehiculo);
            }
        }
        foreach (Vehiculo vehiculo in VehiculosEnStock)
        {
            vehiculo.ModificarPrecio(1.0 - TasaDescuento);
        }
    }
    
    public void Anula()
    {
        foreach (Vehiculo vehiculo in VehiculosEnStock)
        {
            vehiculo.ModificarPrecio(1.0 / (1.0 - TasaDescuento));
        }
    }
    
    public void Restablece()
    {
        foreach (Vehiculo vehiculo in VehiculosEnStock)
        {
            vehiculo.ModificarPrecio(1.0 - TasaDescuento);
        }
    }
    #endregion
}