using System;

namespace SistemaGestaoEventos;

public abstract class EntidadeComID
{
    public String Id {get; set;}

    public virtual string ObterDescricao()
    {
        return Id;
    }
}
