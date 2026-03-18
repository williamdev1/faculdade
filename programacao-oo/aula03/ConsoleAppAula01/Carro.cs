using System;

namespace ConsoleAppAula01;

public class Carro : Veiculo
{
    public Carro()
    {
        DescricaoDoVeiculo = "Carro de Passeio";

    }
    public override string MinhaDescricao()
    {
        return "Carro de passeio";
    }
}
