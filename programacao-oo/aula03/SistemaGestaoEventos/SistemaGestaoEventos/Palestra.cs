using System;

namespace SistemaGestaoEventos;

public class Palestra : EntidadeComID
{
    public String Titulo { get; set; }
    public Participante[] Participantes { get; set; }
    public Palestrante[] Palestrantes { get; set; }
}
