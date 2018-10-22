using System;

public interface Visitante
{
    void Visita(EmpresaSinFilial empresa);
    void Visita(EmpresaMadre empresa);
}