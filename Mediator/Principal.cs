using System;

public class Principal
{
    static void Main(string[] args)
    {
        Formulario formulario = new Formulario();
        formulario.AgregaControl(new ZonaInformacion("Nombre"));
        formulario.AgregaControl(new ZonaInformacion("Apellidos"));
        PopupMenu menu = new PopupMenu("Coprestatario");
        menu.AgregaOpcion("sin prestatario");
        menu.AgregaOpcion("con prestatario");
        formulario.AgregaControl(menu);
        formulario.MenuCoprestatario = menu;
        Boton boton = new Boton("OK");
        formulario.AgregaControl(boton);
        formulario.BotonOK = boton;
        formulario.AgregaControlCoprestatario(new ZonaInformacion("Nombre del coprestatario"));
        formulario.AgregaControlCoprestatario(new ZonaInformacion("Apellidos del coprestatario"));
        formulario.Informa();
    }
}