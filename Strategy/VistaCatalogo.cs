using System.Collections.Generic;

public class VistaCatalogo
{
    #region snippet_Properties
    protected IList<VistaVehiculo> Contenido = new List<VistaVehiculo>();
    protected IDibujaCatalogo Dibujo;
    #endregion
        
    #region snippet_Constructor
    Contenido.Add(new VistaVehiculo("vehículo económico"));
    Contenido.Add(new VistaVehiculo("vehículo especial"));
    Contenido.Add(new VistaVehiculo("vehículo rápido"));
    Contenido.Add(new VistaVehiculo("vehículo confortable"));
    #endregion
        
    #region snippet_Methods
    public void Dibuja()
    {
        Dibujo.Dibuja(Contenido);
    }
    #endregion
}