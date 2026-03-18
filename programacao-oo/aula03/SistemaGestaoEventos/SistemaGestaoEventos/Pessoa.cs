using System;

namespace SistemaGestaoEventos;

public class Pessoa : EntidadeComID
{
    public String Nome {get; set;}
    public String Email {get; set;}
    public String Telefone {get; set;}
    public String CPF {get; set;}
}
