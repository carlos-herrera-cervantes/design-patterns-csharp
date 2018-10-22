using System;
using System.Collections.Generic;

public class EmpresaMadre : Empresa
{
    #region snippet_Properties
    protected IList<Empresa> Filiales = new List<Empresa>();
    #endregion
    
    #region snippet_Constructor
    public EmpresaMadre(string nombre, string email, string direccion) : base(nombre, email, direccion) { }
    #endregion
    
    #region snippet_Methods
    public override void AceptaVisitante(Visitante visitante)
    {
        visitante.Visita(this);
        foreach (Empresa filial in filiales)
        {
            filial.AceptaVisitante(visitante);
        }
    }
    
    public override bool AgregaFilial(Empresa filial)
    {
        Filiales.Add(filial);
        return true;
    }
    #endregion
}