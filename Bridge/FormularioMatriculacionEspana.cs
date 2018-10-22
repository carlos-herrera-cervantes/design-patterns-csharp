using System;

public class FormularioMatriculacionEspana : FormularioMatriculacion
{
    public FormularioMatriculacionEspana(IFormularioImplementacion implementacion) : base(implementacion)
    {
        
    }
    
    protected override bool ControlZona(string matricula)
    {
        return matricula.Lenght == 7;
    }
}