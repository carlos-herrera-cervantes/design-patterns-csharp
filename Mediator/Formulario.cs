using System;
using System.Collections.Generic;

public class Formulario
{
    #region snippet_Properties
    protected IList<Control> Controles = new List<Control>();
    protected IList<Control> ControlesCoprestatario = new List<Control>();
    public PopupMenu MenuCoprestatario { protected get; set; }
    public Boton BotonOK { protected get; set; }
    protected bool EnCurso = true;
    #endregion
        
    #region snippet_Methods
    public void AgregaControl(Control control)
    {
        Controles.Add(control);
        control.Director = this;
    }
    
    public void AgregaControlCoprestatario(Control control)
    {
        ControlesCoprestatario.Add(control);
        control.Director = this;
    }
    
    public void ControlModificado(Control control)
    {
        if (control == MenuCoprestatario)
        {
            if (control.Valor == "con coprestatario")
            {
                foreach (Control elementoCoprestatario in ControlesCoprestatario)
                {
                    elementoCoprestatario.Informa();
                }
            }
        }
        if (control == BotonOK)
        {
            EnCurso = false;
        }
    }
    
    public void Informa()
    {
        while (true)
        {
            foreach (Control control in Controles)
            {
                control.Informa();
                if (!EnCurso)
                {
                    return;
                }
            }
        }
    }
    #endregion
}