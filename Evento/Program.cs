namespace Evento;

class Program
{
    static void Main(string[] args)
    {
        Local local = new Local();
        Console.WriteLine("Informe o nome do local:");
        var nomeLocal = Console.ReadLine();
        Console.WriteLine("Informe o endereco do local:");
        var enderecoLocal = Console.ReadLine();
        Console.WriteLine("Informe a capacidade");
        var capacidade = Console.ReadLine();
        local.Nome = nomeLocal;
        local.Endereco = enderecoLocal;
        local.Capacidade = capacidade;
        return local;

        Evento e1 = new Evento();
        
    }
    private static void Main(string[] args)
    {
        
    }
}
