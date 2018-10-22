using System.Collections.Generic;

public class Catalogo
{
    #region snippet_Properties
    protected IList<Vehiculo> VehiculosStock = new List<Vehiculo>();
    protected IList<SolicitudRebaja> Solicitudes = new List<Vehiculo>();
    #endregion
    
    #region snippet_Methods
    public void EjecutaSolicitudRebaja(SolicitudRebaja solicitud)
    {
        Solicitudes.Insert(0, solicitud);
        solicitud.Rebaja(VehiculosStock);
    }
    
    public void AnulaSolicitudRebaja(int orden)
    {
        Solicitudes[orden].Anula();
    }
    
    public void RestableceSolicitudRebaja(int orden)
    {
        Solicitudes[orden].Restablece();
    }
    
    public void Agrega(Vehiculo vehiculo)
    {
        VehiculosStock.Add(vehiculo);
    }
    
    public void Visualiza()
    {
        foreach (Vehiculo vehiculo in VehiculosStock)
        {
            vehiculo.Visualiza();
        }
    }
    #endregion
}