using System;

public class Principal
{
    static void Main(string[] args)
    {
        Empresa empresa1 = new EmpresaSinFilial("empresa1", "info@gempresa1.com", "calle de la empresa 1");
        Empresa empresa2 = new EmpresaSinFilial("empresa2", "info2@empresa2.com", "calle de la empresa 2");
        Empresa grupo1 = new EmpresaMadre("grupo1", "info@grupo1.com", "Calle del grupo 1");
        grupo1.AgregaFilial(empresa1);
        grupo1.AgregaFilial(empresa2);
        Empresa empresa3 = new EmpresaSinFilial("empresa3", "info@empresa3.com", "calle de la empresa 3");
        Empresa grupo2 = new EmpresaMadre("grupo2", "info@grupo2.com", "calle del grupo 2");
        grupo2.AgregaFilial(grupo1);
        grupo2.AgregaFilial(empresa3);
        grupo2.AceptaVisitante(new VisitanteMailingComercial());
    }
}