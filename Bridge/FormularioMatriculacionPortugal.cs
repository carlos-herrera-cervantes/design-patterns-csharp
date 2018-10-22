using System;

public class FormularioMatriculacionPortugal : FormularioMatriculacion
{
    public FormularioMatriculacionPortugal(IFormularioImplementacion implementacion) : base(implementacion)
    {
        
    }
    
    protected override bool ControlZona(string matricula)
    {
        return matricula.Length == 6;
    }
}