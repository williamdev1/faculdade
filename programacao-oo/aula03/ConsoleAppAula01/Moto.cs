using System;

namespace ConsoleAppAula01;

public class Moto : Veiculo
{
    public int CC {get; set;}
    public Moto()
    {
        DescricaoDoVeiculo = "minha moto";
    }

    public override string MinhaDescricao()
    {
        return "Moto";
    }
}
