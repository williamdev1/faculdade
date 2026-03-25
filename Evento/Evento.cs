using System;

namespace Evento;

public class Evento
{
    public DateTime Inicio{get;set;}
    public DateTime Fim{get;set;}
    public Local Local{get;set;}
    public Palestrante[] Palestrantes{get;set;}
    
}
