namespace app;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Qual seu idioma? / Hola, que idioma hablas?");
        Console.WriteLine(" 1 - Português");
        Console.WriteLine(" 2 - Español");
        int opcao = int.Parse(Console.ReadLine());
        
        if(opcao == 1)
        {
            Console.WriteLine("Qual prato você vai querer?");
            Console.WriteLine("1 - Arroz e feijão");
            Console.WriteLine("2 - Batata assada");
            Console.WriteLine("3 - Lasanha");
            int opcaoprato = int.Parse(Console.ReadLine());
        }
        else if (opcao == 2)
        {
            Console.WriteLine("Qué plato vas a querer?");
            Console.WriteLine("1 - Arroz y frijoles");
            Console.WriteLine("2 - Patatas asadas");
            Console.WriteLine("3 - Lasaña");
            int opcaoprato = int.Parse(Console.ReadLine());
        }

    }
}
