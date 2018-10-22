using System;

public class EmpresaSinFilial : Empresa
{
    #region snippet_Constructor
    public EmpresaSinFilial(string nombre, string email, string direccion) : base(nombre, email, direccion) { }
    #endregion
    
    #region snippet_Methods
    public override void AceptaVisitante(Visitante visitante)
    {
        visitante.Visita(this);
    }
    
    public override bool AgregaFilial(Empresa filial)
    {
        return false;
    }
    #endregion
}